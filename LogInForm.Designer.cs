namespace livrable
{
    partial class LogInForm
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
            loginName = new TextBox();
            loginPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // loginName
            // 
            loginName.Location = new Point(313, 146);
            loginName.Name = "loginName";
            loginName.Size = new Size(230, 31);
            loginName.TabIndex = 0;
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(313, 239);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(230, 31);
            loginPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 152);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 2;
            label1.Text = "nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 245);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 3;
            label2.Text = "mot de passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(335, 43);
            label3.Name = "label3";
            label3.Size = new Size(172, 45);
            label3.TabIndex = 4;
            label3.Text = "Connexion";
            // 
            // button1
            // 
            button1.Location = new Point(645, 382);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 5;
            button1.Text = "connexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginPassword);
            Controls.Add(loginName);
            Name = "LogInForm";
            Text = "LogInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox loginName;
        private TextBox loginPassword;
    }
}