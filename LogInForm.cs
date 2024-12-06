using livrable.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livrable
{
    public partial class LogInForm : Form
    {
        UserRepository userRepository;
        public LogInForm(UserRepository userRepository)
        {
            this.userRepository = userRepository;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categories Categories = new categories();
            DepensesRepository depenses = new DepensesRepository();

            //initialiser des transactions par defaut
            depenses.addDepense(new Depense
            {
                description = "achat d'une television",
                categorie = "immobilier",
                date = DateTime.Now,
                prix = "$100000",
                entreprise = "Best buy"
                
            });
            depenses.addDepense(new Depense
            {
                description = "viande de porc",
                categorie = "epicerie",
                date = DateTime.Now,
                prix = "$80",
                entreprise = "Maxi"

            });
            depenses.addDepense(new Depense
            {
                description = "facture d'electricite",
                categorie = "immobilier",
                date = DateTime.Now,
                prix = "$180",
                entreprise = "bailleur"
             
            });

            if (userRepository.isUser(loginName.Text,loginPassword.Text))
            {
                //initialiser des categorie par defaut
                Categories.addCategorie("epicerie", Properties.Resources.groceries);
                Categories.addCategorie("immobilier", Properties.Resources.immobilier);
                Form1 overView = new Form1(this,userRepository.getUser(loginName.Text, loginPassword.Text), Categories, depenses);
                overView.Show();
                this.Close();

            }

         
        }
    }
}
