namespace livrable
{
    partial class SignInForm
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
            signIn_tb = new TextBox();
            signIn_mail = new TextBox();
            signIn_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // signIn_tb
            // 
            signIn_tb.Location = new Point(294, 139);
            signIn_tb.Name = "signIn_tb";
            signIn_tb.Size = new Size(242, 31);
            signIn_tb.TabIndex = 0;
            // 
            // signIn_mail
            // 
            signIn_mail.Location = new Point(294, 208);
            signIn_mail.Name = "signIn_mail";
            signIn_mail.Size = new Size(242, 31);
            signIn_mail.TabIndex = 1;
            // 
            // signIn_password
            // 
            signIn_password.Location = new Point(294, 284);
            signIn_password.Name = "signIn_password";
            signIn_password.Size = new Size(242, 31);
            signIn_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(279, 44);
            label1.Name = "label1";
            label1.Size = new Size(262, 45);
            label1.TabIndex = 3;
            label1.Text = "Creez un compte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 145);
            label2.Name = "label2";
            label2.Size = new Size(49, 25);
            label2.TabIndex = 4;
            label2.Text = "nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 214);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 5;
            label3.Text = "mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 290);
            label4.Name = "label4";
            label4.Size = new Size(120, 25);
            label4.TabIndex = 6;
            label4.Text = "mot de passe";
            // 
            // button1
            // 
            button1.Location = new Point(650, 390);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Inscription";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 335);
            label5.Name = "label5";
            label5.Size = new Size(227, 25);
            label5.TabIndex = 8;
            label5.Text = "vous avez deja un compte?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(491, 335);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(96, 25);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Connexion";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(signIn_password);
            Controls.Add(signIn_mail);
            Controls.Add(signIn_tb);
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private LinkLabel linkLabel1;
        private TextBox signIn_tb;
        private TextBox signIn_mail;
        private TextBox signIn_password;
    }
}