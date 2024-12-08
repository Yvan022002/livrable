using livrable.model;

namespace livrable
{
    public partial class TransactionForm : Form
    {
        DepensesProvider depenses_provider;
        CategoriesProvider categories_provider;

        public TransactionForm(DepensesProvider depenses_provider, CategoriesProvider categories_provider)
        {
            this.depenses_provider = depenses_provider;
            this.categories_provider = categories_provider;
            InitializeComponent();
            txt_cat.DataSource = categories_provider.categories.ToList();
            lbl_amount_err.Visible = false;
        }

        private void btn_addTransaction_Click(object sender, EventArgs e)
        {
            var desc = txt_desc.Text;
            var cat = txt_cat.Text;
            var date = date_Transaction.Value;
            var amount_success = Double.TryParse(txt_price.Text, out var amount);
            var entreprise = txt_entreprise.Text;

            if (amount_success)
            {
                lbl_amount_err.Visible = false;

                depenses_provider.AddDepense(new Depense
                {
                    Description = desc,
                    Category = cat,
                    Date = date,
                    Entreprise = entreprise,
                    Amount = amount
                });

                Clear();
            }
            else
            {
                lbl_amount_err.Visible = true;
            }
        }

        private void Clear()
        {
            txt_desc.Clear();
            txt_cat.SelectedIndex = 0;
            date_Transaction.Value = DateTime.Now;
            txt_price.Clear();
            txt_entreprise.Clear();
        }
    }
}
