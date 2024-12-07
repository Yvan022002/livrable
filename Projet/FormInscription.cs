using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class FormInscription : Form
    {
        private List<Compte> comptes;
        private Label lblMessage;


        public FormInscription()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void InitMyComponents()
        {

            tb_courriel.TextChanged += CourrielChange;
            comptes = new List<Compte>();
            tb_passeword.TextChanged += PasswordChange;
            tb_confiemed_passord.TextChanged += txtConfirmPassword_TextChanged;


            // Création de l'objet Label
            lblMessage = new Label
            {
                Text = "",
                AutoSize = true, // Permet au label de s'ajuster à la taille du texte
                Location = new Point(230, 505), // Position dans le formulaire
                ForeColor = Color.Black // Couleur initiale du texte
            };

            // Ajout au formulaire
            this.Controls.Add(lblMessage);
        }


        private void CreerCompte()
        {
            // var comptes = new List<Compte>();

            comptes.Add(new Compte { Prenom = "John", Nom = "Wick", Courriel = "donotkill@my.dog", MotDePasse = "asdfsdfsdf", Abonnement = 0 });
            comptes.Add(new Compte { Prenom = "John", Nom = "Malchovick", Courriel = "being@him.com", MotDePasse = "asdfsdfsdf", Abonnement = 1 });
            comptes.Add(new Compte { Prenom = "Frédéric", Nom = "Bergeron", Courriel = "courriel@serveur.domaine", MotDePasse = "asdfsdfsdf", Abonnement = 0 });
        }

        public bool IsEmailAddressValid(string email)
        {
            try
            {
                Regex reg = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}$",
                            RegexOptions.IgnoreCase);
                return (reg.IsMatch(email));
            }
            catch
            {
                return false;
            }
        }

        private void CourrielChange(object sender, EventArgs e)
        {
            string email = tb_courriel.Text;


            if (IsEmailAddressValid(email))
            {
                var compteExistant = comptes.FirstOrDefault(b => b.Courriel == email);
                if (compteExistant != null)
                {
                    // Idem
                    tb_courriel.BackColor = Color.Coral;

                }
                else
                {
                    /// Idem
                    tb_courriel.BackColor = Color.Aquamarine;
                }

                tb_courriel.BackColor = Color.Aquamarine;
            }
            else
            {
                tb_courriel.BackColor = Color.Coral;
            }
        }


        private bool IsPasswordValid(string password)
        {
            // Vérification des critères de mot de passe
            bool hasMinimumLength = password.Length >= 12;
            bool hasUpperCase = Regex.IsMatch(password, "[A-Z]");
            bool hasLowerCase = Regex.IsMatch(password, "[a-z]");
            bool hasDigit = Regex.IsMatch(password, @"\d");
            bool hasSpecialCharacters = Regex.Matches(password, @"[@#$%&*;:~]").Count >= 2;

            // Retourne true seulement si tous les critères sont remplis
            return hasMinimumLength && hasUpperCase && hasLowerCase && hasDigit && hasSpecialCharacters;
        }

        private void PasswordChange(object sender, EventArgs e)
        {
            string password = tb_passeword.Text;

            bool hasMinimumLength = password.Length >= 12;
            bool hasUpperCase = Regex.IsMatch(password, "[A-Z]");
            bool hasLowerCase = Regex.IsMatch(password, "[a-z]");
            bool hasDigit = Regex.IsMatch(password, @"\d");
            bool hasSpecialCharacters = Regex.Matches(password, @"[@#$%&*;:~]").Count >= 2;

            // Vérification de chaque critère pour définir la couleur globale
            if (IsPasswordValid(password))
            {
                tb_passeword.BackColor = Color.Aquamarine; // Mot de passe valide (vert)
            }
            else
            {
                tb_passeword.BackColor = Color.Coral; // Mot de passe non valide (rouge)
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            // Vérification si les mots de passe correspondent
            if (tb_passeword.Text == tb_confiemed_passord.Text)
            {
                lblMessage.Text = "Les mots de passe correspondent.";
                lblMessage.ForeColor = Color.Green;
                tb_confiemed_passord.BackColor = Color.Aquamarine;
            }
            else
            {
                lblMessage.Text = "Les mots de passe ne correspondent pas.";
                lblMessage.ForeColor = Color.Coral;
                tb_confiemed_passord.BackColor = Color.Coral;
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void FormInscription_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void overview(object sender, EventArgs e)
        {

        }
    }
}
