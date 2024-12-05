using livrable.Properties;
using System.Resources;
using System.Windows.Forms;
using livrable.model;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;

namespace livrable
{
    public partial class Form1 : Form, IObserver
    {
        categories cats;
        DepensesRepository depensesRepository;

        public Form1(categories initialCats, DepensesRepository depenses)
        {

            cats = initialCats;
            depensesRepository = depenses;
            cats.attachObserver(this);
            depensesRepository.attachObserver(this);
            InitializeComponent();
            loadAllCategories();



        }
        public categories GetCategories() { return cats; }
        public DepensesRepository GetDepenses() { return depensesRepository; }
        public void loadAllCategories()
        {
            foreach (Panel p in cats.GetAllCategories())
            {
                allCategoriesPanel.Controls.Add(p);
            }
        }

        //determine d'ou vient la msie a jours
        public void update(ISujet sujet)
        {
            if (sujet is DepensesRepository)
            {
                updateDepense(sujet);
            }
            else if (sujet is categories)
            {
                updateCategorie(sujet);
            }
        }

        //upadte le tableau des depenses
        public void updateDepense(object depenses)
        {

            DepensesRepository des = (DepensesRepository)depenses;
            foreach (Depense p in des.GetDepenses())
            {
                allTransaction.Rows.Add(p.description, p.categorie, p.date, p.prix, p.entreprise);
            }

        }
        //update la liste des categories
        public void updateCategorie(object allCat)
        {
            allCategoriesPanel.Controls.Clear();
            categories Categories = (categories)allCat;
            foreach (Panel p in Categories.GetAllCategories())
            {
                allCategoriesPanel.Controls.Add(p);
            }
            allCategoriesPanel.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {

        }



        private void btn_openCategorieForm_Click(object sender, EventArgs e)
        {
            categorieForm CategorieForm = new categorieForm(this);
            CategorieForm.Show();
        }

        private void btn_openTransactionForm_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(this);
            transactionForm.Show();
        }
    }
}
