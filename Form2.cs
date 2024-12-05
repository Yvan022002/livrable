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
    public partial class Form2 : Form
    {
        // Dictionnaire pour stocker les informations associées à chaque période
        private Dictionary<string, (string Notes, int CurrentExpenses, int TotalBudget)> budgets = new();

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }
        // Afficher les informations dans les TextBox lorsque la période est sélectionnée
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedPeriod = comboBox1.SelectedItem.ToString();

                if (budgets.TryGetValue(selectedPeriod, out var budgetInfo))
                {
                    textBox1.Text = selectedPeriod; // Period
                    textBox2.Text = budgetInfo.Notes; // Notes
                    textBox3.Text = $"{budgetInfo.CurrentExpenses}$"; // Current Expenses
                    textBox4.Text = $"{budgetInfo.TotalBudget}$"; // Total Budget

                    // Calculer la différence
                    int difference = budgetInfo.TotalBudget - budgetInfo.CurrentExpenses;
                    textBox5.Text = $"{difference}$"; // Difference
                    textBox6.Text = difference >= 0 ? "Oui" : "Non"; // On Budget
                    if (difference >= 0)
                    {
                        textBox6.BackColor = Color.LightGreen; // Vert pour "Yes"
                    }
                    else
                    {
                        textBox6.BackColor = Color.LightCoral; // Rouge pour "No"
                    }
                }
            }
        }
        private void BtnSubmitBudget_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs saisies
            string period = textBoxPeriod.Text;
            string notes = textBoxNotes.Text;

            if (int.TryParse(textBoxCurrentExpenses.Text, out int currentExpenses) &&
                int.TryParse(textBoxTotalBudget.Text, out int totalBudget))
            {
                // Ajouter les données au dictionnaire
                budgets[period] = (notes, currentExpenses, totalBudget);

                // Ajouter la période au ComboBox
                comboBox1.Items.Add(period);

                // Effacer les champs et masquer le panel
                textBoxPeriod.Clear();
                textBoxNotes.Clear();
                textBoxCurrentExpenses.Clear();
                textBoxTotalBudget.Clear();
                panelAddBudget.Visible = false;
            }
            else
            {
                MessageBox.Show("Veuillez entrer des valeurs valides pour les dépenses et le budget total.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddBudget_Click(object sender, EventArgs e)
        {
            panelAddBudget.Visible = true; // Afficher le panel
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAddBudget_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
