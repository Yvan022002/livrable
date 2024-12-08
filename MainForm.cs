using livrable.model;

namespace livrable
{
    public partial class MainForm : Form
    {
        DepensesProvider depenses;
        CategoriesProvider categories;
        BudgetProvider budget;

        OverviewControl overview;
        RapportControl rapport;

        public MainForm()
        {
            InitializeComponent();

            depenses = new DepensesProvider();
            categories = new CategoriesProvider();
            budget = new BudgetProvider();

            depenses.MockData();
            categories.MockData();

            rapport = new RapportControl(depenses, categories);
            overview = new OverviewControl(depenses, categories, budget);

            lbl_page_title.Text = "Tableau de bord";
            pnl_page.Controls.Add(overview);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            lbl_page_title.Text = "Tableau de bord";
            pnl_page.Controls.Clear();
            pnl_page.Controls.Add(overview);
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            lbl_page_title.Text = "Rapport";
            pnl_page.Controls.Clear();
            pnl_page.Controls.Add(rapport);
        }

        private void btn_budget_Click(object sender, EventArgs e)
        {
            lbl_page_title.Text = "Budget";
            pnl_page.Controls.Clear();

        }
    }
}
