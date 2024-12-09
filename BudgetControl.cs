using livrable.model;
using System.Data;

namespace livrable
{
    public record struct Budget(string name, DateTime start, DateTime end, double amount);

    public partial class BudgetControl : UserControl
    {
        DepensesProvider depenses_provider;
        List<Budget> budgets = [];

        public BudgetControl(DepensesProvider depenses_provider)
        {
            this.depenses_provider = depenses_provider;

            InitializeComponent();
            SetupDataTable();

            data_budgets.SelectionChanged += SelectionChanged;
        }

        private void SetupDataTable()
        {
            // Create the columns for the DataGridView
            data_budgets.Columns.Add("Name", "Nom");
            data_budgets.Columns.Add("Start", "Début");
            data_budgets.Columns.Add("End", "Fin");
            data_budgets.Columns.Add("Amount", "Montant");

            // Set column format for Amount to display as currency
            data_budgets.Columns["Amount"].DefaultCellStyle.Format = "C2";

            // Set the Date column format
            data_budgets.Columns["Start"].DefaultCellStyle.Format = "dd/MM/yyyy";
            data_budgets.Columns["End"].DefaultCellStyle.Format = "dd/MM/yyyy";

            data_budgets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void RefreshBudget(DateTime start, DateTime end, double amount)
        {
            var monthly_total = depenses_provider.depenses.Values
                                    .Where((item) => item.Date >= start && item.Date <= end)
                                    .Select((item) => item.Amount)
                                    .Sum();

            lbl_selected_budget.Text = $"{monthly_total:C2} / {amount:C2}";

            if (monthly_total > amount)
            {
                lbl_selected_budget.ForeColor = Color.Red;
            }
            else if (monthly_total > 0.70 * amount)
            {
                lbl_selected_budget.ForeColor = Color.Orange;
            }
            else
            {
                lbl_selected_budget.ForeColor = Color.Green;
            }
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (data_budgets.SelectedRows.Count > 0)
            {
                // Get the selected row (the first selected row in case of multi-selection)
                DataGridViewRow selectedRow = data_budgets.SelectedRows[0];

                var amount = Convert.ToDouble(selectedRow.Cells["Amount"].Value);
                var start = Convert.ToDateTime(selectedRow.Cells["Start"].Value);
                var end = Convert.ToDateTime(selectedRow.Cells["End"].Value);

                RefreshBudget(start, end, amount);
                lbl_selected_budget.Visible = true;
            }
        }

        private void btn_add_budget_Click(object sender, EventArgs e)
        {

            var name = box_name.Text;
            var end = picker_end.Value;
            var start = picker_start.Value;
            var amount_success = Double.TryParse(box_amount.Text, out var amount);

            if (!amount_success)
            {
                lbl_err.Text = "Entrez un montant numérique valide";
                lbl_err.Visible = true;
                return;
            }

            if (end < start)
            {
                lbl_err.Text = "La date de début doit précéder la date de fin";
                lbl_err.Visible = true;
                return;
            }


            lbl_err.Visible = false;
            data_budgets.Rows.Add(name, start, end, amount);

            Clear();

        }


        void Clear()
        {
            box_name.Clear();
            picker_start.Value = DateTime.Now;
            picker_end.Value = DateTime.Now;
            box_amount.Clear();
        }
    }
}