namespace livrable;

using livrable.model;

using Categories2 = SortedSet<string>;
using Depenses = SortedDictionary<Guid, model.Depense>;

public partial class OverviewControl : UserControl, IObserver<Categories2>, IObserver<Depenses>
{
    private DepensesProvider.Unsubscriber depenses_unsubscriber;
    private CategoriesProvider.Unsubscriber categories_unsubscriber;
    private BudgetProvider.Unsubscriber budget_unsubscriber;

    DepensesProvider depenses_provider;
    CategoriesProvider categories_provider;

    public OverviewControl(DepensesProvider depenses_provider, CategoriesProvider categories_provider)
    {
        this.depenses_provider = depenses_provider;
        this.categories_provider = categories_provider;

        depenses_provider.Subscribe(this);
        categories_provider.Subscribe(this);

        InitializeComponent();
        SetupDataTable();
        RefreshDepenses(depenses_provider.depenses);
        RefreshCategories(categories_provider.categories);
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


    public void OnNext(Depenses value)
    {
        RefreshDepenses(value);
    }

    public void OnNext(Categories2 value)
    {
        RefreshCategories(value);
    }

    private void SetupDataTable()
    {
        // Create the columns for the DataGridView
        datagrid_transactions.Columns.Add("Enterprise", "Entreprise");
        datagrid_transactions.Columns.Add("Description", "Description");
        datagrid_transactions.Columns.Add("Amount", "Montant");
        datagrid_transactions.Columns.Add("Category", "Catégorie");
        datagrid_transactions.Columns.Add("Date", "Date");

        // Set column format for Amount to display as currency
        datagrid_transactions.Columns["Amount"].DefaultCellStyle.Format = "C2";

        // Set the Date column format
        datagrid_transactions.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";

        datagrid_transactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    }

    private void RefreshDepenses(Depenses depenses)
    {
        datagrid_transactions.Rows.Clear();

        foreach (var depense in depenses.Values.Where((item) => item.Date.Month == DateTime.Now.Month))
        {
            datagrid_transactions.Rows.Add(depense.Entreprise, depense.Description, depense.Amount, depense.Category, depense.Date);

        }
    }

    private void RefreshCategories(Categories2 categories)
    {
        listbox_categories.Items.Clear();
        foreach (var category in categories)
        {
            listbox_categories.Items.Add(category);
        }
    }

    private void btn_transctions_Click(object sender, EventArgs e)
    {
        (new TransactionForm(depenses_provider, categories_provider)).ShowDialog(this);
    }

    private void btn_categories_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textbox_categories.Text))
        {
            categories_provider.AddCategory(textbox_categories.Text);
        }
    }
}
