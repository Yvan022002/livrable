namespace Projet
{
    partial class FormInscription
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tb_courriel = new TextBox();
            tb_passeword = new TextBox();
            tb_confiemed_passord = new TextBox();
            groupBox1 = new GroupBox();
            bt_overwiew = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(313, 109);
            label1.Name = "label1";
            label1.Size = new Size(217, 30);
            label1.TabIndex = 0;
            label1.Text = "S'inscrire à notre app";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 19);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Nom";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(16, 19);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 3;
            label4.Text = "Nom";
            label4.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(16, 84);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 3;
            label5.Text = "Prenom";
            label5.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(16, 150);
            label7.Name = "label7";
            label7.Size = new Size(131, 21);
            label7.TabIndex = 4;
            label7.Text = "Addresse courriel";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(16, 216);
            label8.Name = "label8";
            label8.Size = new Size(102, 21);
            label8.TabIndex = 4;
            label8.Text = "Mot de passe";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(16, 284);
            label9.Name = "label9";
            label9.Size = new Size(193, 21);
            label9.TabIndex = 4;
            label9.Text = "Confirmer le mot de passe";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(16, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 29);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(16, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(348, 29);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // tb_courriel
            // 
            tb_courriel.Font = new Font("Segoe UI", 12F);
            tb_courriel.Location = new Point(16, 174);
            tb_courriel.Name = "tb_courriel";
            tb_courriel.Size = new Size(348, 29);
            tb_courriel.TabIndex = 5;
            tb_courriel.TextChanged += textBox3_TextChanged;
            // 
            // tb_passeword
            // 
            tb_passeword.Font = new Font("Segoe UI", 12F);
            tb_passeword.Location = new Point(16, 240);
            tb_passeword.Name = "tb_passeword";
            tb_passeword.Size = new Size(348, 29);
            tb_passeword.TabIndex = 5;
            tb_passeword.UseSystemPasswordChar = true;
            // 
            // tb_confiemed_passord
            // 
            tb_confiemed_passord.Font = new Font("Segoe UI", 12F);
            tb_confiemed_passord.Location = new Point(16, 308);
            tb_confiemed_passord.Name = "tb_confiemed_passord";
            tb_confiemed_passord.Size = new Size(348, 29);
            tb_confiemed_passord.TabIndex = 5;
            tb_confiemed_passord.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(tb_confiemed_passord);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tb_passeword);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(tb_courriel);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(226, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 361);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // bt_overwiew
            // 
            bt_overwiew.Font = new Font("Segoe UI", 12F);
            bt_overwiew.Location = new Point(513, 509);
            bt_overwiew.Name = "bt_overwiew";
            bt_overwiew.Size = new Size(95, 27);
            bt_overwiew.TabIndex = 9;
            bt_overwiew.Text = "S'inscrire";
            bt_overwiew.UseVisualStyleBackColor = true;
            bt_overwiew.Click += button4_Click;
            // 
            // FormInscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 842);
            Controls.Add(bt_overwiew);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormInscription";
            Text = "Form2";
            Load += FormInscription_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tb_courriel;
        private TextBox tb_passeword;
        private TextBox tb_confiemed_passord;
        private GroupBox groupBox1;
        private Button bt_overwiew;
    }
}