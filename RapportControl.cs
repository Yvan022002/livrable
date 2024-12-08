using livrable.model;
using System.Windows.Forms.DataVisualization.Charting;

namespace livrable;

using Categories2 = SortedSet<string>;
using Depenses = SortedDictionary<Guid, Depense>;


public partial class RapportControl : UserControl, IObserver<Depenses>, IObserver<Categories2>
{
    private readonly IDisposable depenses_unsubscriber;
    private readonly IDisposable categories_unsubscriber;
    private readonly DepensesProvider depenses_provider;
    private readonly CategoriesProvider categories_provider;

    public RapportControl(DepensesProvider depenses_provider, CategoriesProvider categories_provider)
    {
        depenses_unsubscriber = depenses_provider.Subscribe(this);
        categories_unsubscriber = categories_provider.Subscribe(this);
        this.depenses_provider = depenses_provider;
        this.categories_provider = categories_provider;

        InitializeComponent();
        CreateStackedColumnChart();
        RefreshChart();
        SetupDataTable();
    }

    public void Display()
    {
        this.Visible = true;
        RefreshChart();
        dataGridView1.Rows.Clear();
    }

    private void CreateStackedColumnChart()
    {
        // Set chart area
        ChartArea chartArea = new ChartArea();
        chartArea.Name = "ChartArea1";
        chart1.ChartAreas.Add(chartArea);
        chart1.ChartAreas[0].AxisX.Interval = 1;
        chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 45;



        // Add event handler for MouseClick
        chart1.MouseClick += Chart1_MouseClick;
    }

    private void RefreshChart()
    {
        chart1.Series.Clear();

        // Create a series for each category
        foreach (var categorie in categories_provider.categories)
        {
            Series series = new(categorie)
            {
                ChartType = SeriesChartType.StackedColumn
            };

            series.IsXValueIndexed = true;

            // Each series will contain a data point for each month
            List<double> mensuel = new(new double[12]);
            // Add 
            foreach (var depense in depenses_provider.depenses.Values.Where((item) => item.Category == categorie))
            {
                mensuel[depense.Date.Month - 1] += depense.Amount;
            }
            for (int mois = 0; mois < 12; mois++)
            {
                var montant_mensuel = mensuel[mois];
                series.Points.AddXY(NumToMonth(mois + 1), montant_mensuel);

            }
            chart1.Series.Add(series);
        }
    }

    private string NumToMonth(int num)
    {
        return num switch
        {
            1 => "Janvier",
            2 => "Février",
            3 => "Mars",
            4 => "Avril",
            5 => "Mai",
            6 => "Juin",
            7 => "Juillet",
            8 => "Août",
            9 => "Septembre",
            10 => "Octobre",
            11 => "Novembre",
            12 => "Décembre",
            _ => "",
        };
    }

    private int MonthToNum(string mois)
    {
        return mois switch
        {
            "Janvier" => 1,
            "Février" => 2,
            "Mars" => 3,
            "Avril" => 4,
            "Mai" => 5,
            "Juin" => 6,
            "Juillet" => 7,
            "Août" => 8,
            "Septembre" => 9,
            "Octobre" => 10,
            "Novembre" => 11,
            "Décembre" => 12,
            _ => -1,
        };
    }

    // Handle the MouseClick event
    private void Chart1_MouseClick(object sender, MouseEventArgs e)
    {
        HitTestResult result = chart1.HitTest(e.X, e.Y);
        if (result.ChartElementType == ChartElementType.DataPoint)
        {
            DataPoint clickedPoint = result.Series.Points[result.PointIndex];
            RefreshDataTable(MonthToNum(clickedPoint.AxisLabel));
        }
    }

    private void SetupDataTable()
    {
        // Create the columns for the DataGridView
        dataGridView1.Columns.Add("Enterprise", "Entreprise");
        dataGridView1.Columns.Add("Description", "Description");
        dataGridView1.Columns.Add("Amount", "Montant");
        dataGridView1.Columns.Add("Category", "Catégorie");
        dataGridView1.Columns.Add("Date", "Date");

        // Set column format for Amount to display as currency
        dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "C2";

        // Set the Date column format
        dataGridView1.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";

        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void RefreshDataTable(int month)
    {
        dataGridView1.Rows.Clear();
        foreach (var depense in depenses_provider.depenses.Values.Where((item) => item.Date.Month == month))
        {
            dataGridView1.Rows.Add(depense.Entreprise, depense.Description, depense.Amount, depense.Category, depense.Date);
        }

    }

    void IObserver<Depenses>.OnCompleted()
    {
        depenses_unsubscriber.Dispose();
    }

    void IObserver<Categories2>.OnCompleted()
    {
        categories_unsubscriber.Dispose();
    }

    public void OnError(Exception error)
    {
        throw new NotImplementedException();
    }

    public void OnNext(Categories2 value)
    {
        dataGridView1.Rows.Clear();
        RefreshChart();
    }

    public void OnNext(Depenses value)
    {
        dataGridView1.Rows.Clear();
        RefreshChart();
    }
}
