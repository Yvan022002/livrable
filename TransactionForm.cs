using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using livrable.model;

namespace livrable
{
    public partial class TransactionForm : Form
    {
        private Form1 form1;
        private categories cats;
        public TransactionForm(Form1 mainForm)
        {
            form1 = mainForm;
            cats=form1.GetCategories();
           
            InitializeComponent();

            loadCategorieOption();

        }

    
  

        private void btn_addTransaction_Click(object sender, EventArgs e)
        {
            var desc = txt_desc.Text;
            var cat = txt_cat.Text;
            var date=date_Transaction.Value;
            var price = txt_price.Text;
            var entreprise = txt_entreprise.Text;
            form1.GetDepenses().addDepense(new Depense
            {
                description = desc,
                categorie = cat,
                date = date,
                entreprise = entreprise,
                prix = price
            });
            this.Close();
        }

        //remplis la list de categorie disponible pour une depense
        //avec toutes les categorie par defaut (ici aucune)
        private void loadCategorieOption()
        {
            List<string> catOptions = new List<string>();
            catOptions = cats.GetCatOptions();
            txt_cat.DataSource= catOptions;
            
        }

        private void addTransaction_Load(object sender, EventArgs e)
        {

        }

      
    }
}
