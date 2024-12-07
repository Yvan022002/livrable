namespace Projet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_passeword = new TextBox();
            tb_courriel = new TextBox();
            label5 = new Label();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox1 = new GroupBox();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F);
            label1.Location = new Point(200, 108);
            label1.Name = "label1";
            label1.Size = new Size(341, 36);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue chez  MonArgent";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F);
            label2.Location = new Point(307, 144);
            label2.Name = "label2";
            label2.Size = new Size(123, 13);
            label2.TabIndex = 1;
            label2.Text = "Veuillez vous identifier";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(15, 28);
            label3.Name = "label3";
            label3.Size = new Size(178, 19);
            label3.TabIndex = 2;
            label3.Text = "Nom d'utilisateur ou couriel";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(15, 96);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 3;
            label4.Text = "Mot de passe";
            // 
            // tb_passeword
            // 
            tb_passeword.Font = new Font("Segoe UI", 12F);
            tb_passeword.Location = new Point(15, 118);
            tb_passeword.Name = "tb_passeword";
            tb_passeword.Size = new Size(339, 29);
            tb_passeword.TabIndex = 4;
            tb_passeword.UseSystemPasswordChar = true;
            // 
            // tb_courriel
            // 
            tb_courriel.Font = new Font("Segoe UI", 12F);
            tb_courriel.Location = new Point(15, 50);
            tb_courriel.Name = "tb_courriel";
            tb_courriel.Size = new Size(339, 29);
            tb_courriel.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 159);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 5;
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(15, 186);
            button1.Name = "button1";
            button1.Size = new Size(339, 38);
            button1.TabIndex = 6;
            button1.Text = "Se connecter";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_courriel);
            groupBox1.Controls.Add(tb_passeword);
            groupBox1.Location = new Point(187, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 264);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(463, 430);
            button2.Name = "button2";
            button2.Size = new Size(100, 37);
            button2.TabIndex = 8;
            button2.Text = "S'inscrire";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 707);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_passeword;
        private TextBox tb_courriel;
        private Label label5;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button2;
    }
}
