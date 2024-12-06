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
    public partial class SignInForm : Form
    {
        UserRepository _userRepository;
        public SignInForm(UserRepository userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            LogInForm logInForm = new LogInForm(_userRepository);
            logInForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = creatUser(signIn_tb.Text, signIn_mail.Text, signIn_password.Text);
            _userRepository.addUser(user); 

            LogInForm logInForm = new LogInForm(_userRepository);
            logInForm.Show();
            this.Hide();
        }
        private User creatUser(string username, string mail, string password)
        {
            return new User
            {
                Name = username,
                Email = mail,
                Password = password
            };
        }
    }
}
