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
    public partial class categorieForm : Form
    {
        private Form1 form1;
        
        public categorieForm(Form1 mianForm)
        {
            InitializeComponent();
            form1 = mianForm;
           
        }

        private void btn_addCat_Click(object sender, EventArgs e)
        {
            form1.GetCategories().addCategorie(txt_nomCat.Text, picBoxTest.Image);
            this.Close();
        }

        private void btn_selectImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configurer le filtre pour les fichiers image
                openFileDialog.Filter = "Images (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif";

                // Ouvrir la boîte de dialogue
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Charger et afficher l'image dans le PictureBox
                    picBoxTest.Image = Image.FromFile(openFileDialog.FileName);
                   
                }
            }
        }
    }
}
