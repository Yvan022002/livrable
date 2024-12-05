namespace livrable
{
    partial class TransactionForm
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
            txt_desc = new TextBox();
            txt_price = new TextBox();
            txt_entreprise = new TextBox();
            btn_addTransaction = new Button();
            date_Transaction = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txt_cat = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(360, 101);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(272, 31);
            txt_desc.TabIndex = 0;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(360, 315);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(272, 31);
            txt_price.TabIndex = 3;
            // 
            // txt_entreprise
            // 
            txt_entreprise.Location = new Point(360, 394);
            txt_entreprise.Name = "txt_entreprise";
            txt_entreprise.Size = new Size(272, 31);
            txt_entreprise.TabIndex = 4;
            // 
            // btn_addTransaction
            // 
            btn_addTransaction.Location = new Point(726, 449);
            btn_addTransaction.Name = "btn_addTransaction";
            btn_addTransaction.Size = new Size(112, 34);
            btn_addTransaction.TabIndex = 5;
            btn_addTransaction.Text = "ajouter";
            btn_addTransaction.UseVisualStyleBackColor = true;
            btn_addTransaction.Click += btn_addTransaction_Click;
            // 
            // date_Transaction
            // 
            date_Transaction.Location = new Point(360, 245);
            date_Transaction.Name = "date_Transaction";
            date_Transaction.Size = new Size(272, 31);
            date_Transaction.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 107);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 8;
            label1.Text = "description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 182);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 9;
            label2.Text = "categorie";
            // 
            // txt_cat
            // 
            txt_cat.FormattingEnabled = true;
            txt_cat.Location = new Point(360, 174);
            txt_cat.Name = "txt_cat";
            txt_cat.Size = new Size(272, 33);
            txt_cat.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 251);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 11;
            label3.Text = "date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 321);
            label4.Name = "label4";
            label4.Size = new Size(41, 25);
            label4.TabIndex = 12;
            label4.Text = "prix";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 400);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 13;
            label5.Text = "entreprise";
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 255, 255);
            ClientSize = new Size(905, 506);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txt_cat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(date_Transaction);
            Controls.Add(btn_addTransaction);
            Controls.Add(txt_entreprise);
            Controls.Add(txt_price);
            Controls.Add(txt_desc);
            Name = "TransactionForm";
            Text = "addTransaction";
            Load += addTransaction_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_desc;
        private TextBox txt;
        private TextBox txt_price;
        private TextBox txt_entreprise;
        private Button btn_addTransaction;
        private DateTimePicker date_Transaction;
        private Label label1;
        private Label label2;
        private ComboBox txt_cat;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}