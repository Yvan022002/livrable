using System.Text.RegularExpressions;

namespace Projet
{
    public partial class Form1 : Form
    {


        private List<Compte> comptes;
        public Form1()
        {
            InitializeComponent();
            InitMyComponents();
        }

        private void CreerCompte()
        {
            // var comptes = new List<Compte>();

            comptes.Add(new Compte { Prenom = "John", Nom = "Wick", Courriel = "donotkill@my.dog", MotDePasse = "asdfsdfsdf", Abonnement = 0 });
            comptes.Add(new Compte { Prenom = "John", Nom = "Malchovick", Courriel = "being@him.com", MotDePasse = "asdfsdfsdf", Abonnement = 1 });
            comptes.Add(new Compte { Prenom = "Frédéric", Nom = "Bergeron", Courriel = "courriel@serveur.domaine", MotDePasse = "asdfsdfsdf", Abonnement = 0 });
        }
        private void btnInscription_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire d'inscription
            FormInscription formInscription = new FormInscription();
            formInscription.Show();
        }

        private void InitMyComponents()
        {


            tb_courriel.TextChanged += CourrielChange;
            comptes = new List<Compte>();
            tb_passeword.TextChanged += PasswordChange;


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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ouvrir le formulaire d'inscription
            FormInscription formInscription = new FormInscription();
            formInscription.Show();
            this.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
