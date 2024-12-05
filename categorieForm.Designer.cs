namespace livrable
{
    partial class categorieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_nomCat = new TextBox();
            lb_cat = new Label();
            btn_selectImg = new Button();
            btn_addCat = new Button();
            picBoxTest = new PictureBox();
            titre_CatForm = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxTest).BeginInit();
            SuspendLayout();
            // 
            // txt_nomCat
            // 
            txt_nomCat.Location = new Point(189, 156);
            txt_nomCat.Name = "txt_nomCat";
            txt_nomCat.Size = new Size(305, 31);
            txt_nomCat.TabIndex = 0;
            // 
            // lb_cat
            // 
            lb_cat.AutoSize = true;
            lb_cat.Location = new Point(123, 162);
            lb_cat.Name = "lb_cat";
            lb_cat.Size = new Size(49, 25);
            lb_cat.TabIndex = 2;
            lb_cat.Text = "nom";
            // 
            // btn_selectImg
            // 
            btn_selectImg.Location = new Point(250, 206);
            btn_selectImg.Name = "btn_selectImg";
            btn_selectImg.Size = new Size(133, 34);
            btn_selectImg.TabIndex = 4;
            btn_selectImg.Text = "select image";
            btn_selectImg.UseVisualStyleBackColor = true;
            btn_selectImg.Click += btn_selectImg_Click;
            // 
            // btn_addCat
            // 
            btn_addCat.Location = new Point(259, 275);
            btn_addCat.Name = "btn_addCat";
            btn_addCat.Size = new Size(112, 34);
            btn_addCat.TabIndex = 5;
            btn_addCat.Text = "ajouter";
            btn_addCat.UseVisualStyleBackColor = true;
            btn_addCat.Click += btn_addCat_Click;
            // 
            // picBoxTest
            // 
            picBoxTest.Location = new Point(403, 199);
            picBoxTest.Name = "picBoxTest";
            picBoxTest.Size = new Size(55, 41);
            picBoxTest.TabIndex = 6;
            picBoxTest.TabStop = false;
            // 
            // titre_CatForm
            // 
            titre_CatForm.AutoSize = true;
            titre_CatForm.Font = new Font("Segoe UI", 16F);
            titre_CatForm.Location = new Point(109, 47);
            titre_CatForm.Name = "titre_CatForm";
            titre_CatForm.Size = new Size(512, 45);
            titre_CatForm.TabIndex = 7;
            titre_CatForm.Text = "Ajouter une Categorie de Depense";
            // 
            // categorieForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 255, 255);
            ClientSize = new Size(697, 419);
            Controls.Add(titre_CatForm);
            Controls.Add(picBoxTest);
            Controls.Add(btn_addCat);
            Controls.Add(btn_selectImg);
            Controls.Add(lb_cat);
            Controls.Add(txt_nomCat);
            Name = "categorieForm";
            Text = "categorieForm";
            ((System.ComponentModel.ISupportInitialize)picBoxTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_nomCat;
        private Label lb_cat;
        private Button btn_selectImg;
        private Button btn_addCat;
        private PictureBox picBoxTest;
        private Label titre_CatForm;
    }
}