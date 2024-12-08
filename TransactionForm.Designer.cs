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
            lbl_description = new Label();
            lbl_category = new Label();
            txt_cat = new ComboBox();
            lbl_date = new Label();
            lbl_montant = new Label();
            lbl_enterprise = new Label();
            label6 = new Label();
            lbl_amount_err = new Label();
            SuspendLayout();
            // 
            // txt_desc
            // 
            txt_desc.Location = new Point(148, 109);
            txt_desc.Margin = new Padding(2);
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new Size(192, 23);
            txt_desc.TabIndex = 0;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(148, 198);
            txt_price.Margin = new Padding(2);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(192, 23);
            txt_price.TabIndex = 3;
            // 
            // txt_entreprise
            // 
            txt_entreprise.Location = new Point(148, 68);
            txt_entreprise.Margin = new Padding(2);
            txt_entreprise.Name = "txt_entreprise";
            txt_entreprise.Size = new Size(192, 23);
            txt_entreprise.TabIndex = 4;
            // 
            // btn_addTransaction
            // 
            btn_addTransaction.Font = new Font("Segoe UI", 12F);
            btn_addTransaction.Location = new Point(177, 296);
            btn_addTransaction.Margin = new Padding(2);
            btn_addTransaction.Name = "btn_addTransaction";
            btn_addTransaction.Size = new Size(128, 46);
            btn_addTransaction.TabIndex = 5;
            btn_addTransaction.Text = "Ajouter";
            btn_addTransaction.UseVisualStyleBackColor = true;
            btn_addTransaction.Click += btn_addTransaction_Click;
            // 
            // date_Transaction
            // 
            date_Transaction.Location = new Point(147, 251);
            date_Transaction.Margin = new Padding(2);
            date_Transaction.Name = "date_Transaction";
            date_Transaction.Size = new Size(192, 23);
            date_Transaction.TabIndex = 7;
            // 
            // lbl_description
            // 
            lbl_description.AutoSize = true;
            lbl_description.Location = new Point(68, 112);
            lbl_description.Margin = new Padding(2, 0, 2, 0);
            lbl_description.Name = "lbl_description";
            lbl_description.Size = new Size(67, 15);
            lbl_description.TabIndex = 8;
            lbl_description.Text = "Description";
            // 
            // lbl_category
            // 
            lbl_category.AutoSize = true;
            lbl_category.Location = new Point(78, 159);
            lbl_category.Margin = new Padding(2, 0, 2, 0);
            lbl_category.Name = "lbl_category";
            lbl_category.Size = new Size(58, 15);
            lbl_category.TabIndex = 9;
            lbl_category.Text = "Catégorie";
            // 
            // txt_cat
            // 
            txt_cat.FormattingEnabled = true;
            txt_cat.Location = new Point(148, 154);
            txt_cat.Margin = new Padding(2);
            txt_cat.Name = "txt_cat";
            txt_cat.Size = new Size(192, 23);
            txt_cat.TabIndex = 10;
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(104, 255);
            lbl_date.Margin = new Padding(2, 0, 2, 0);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(31, 15);
            lbl_date.TabIndex = 11;
            lbl_date.Text = "Date";
            // 
            // lbl_montant
            // 
            lbl_montant.AutoSize = true;
            lbl_montant.Location = new Point(82, 201);
            lbl_montant.Margin = new Padding(2, 0, 2, 0);
            lbl_montant.Name = "lbl_montant";
            lbl_montant.Size = new Size(53, 15);
            lbl_montant.TabIndex = 12;
            lbl_montant.Text = "Montant";
            // 
            // lbl_enterprise
            // 
            lbl_enterprise.AutoSize = true;
            lbl_enterprise.Location = new Point(76, 68);
            lbl_enterprise.Margin = new Padding(2, 0, 2, 0);
            lbl_enterprise.Name = "lbl_enterprise";
            lbl_enterprise.Size = new Size(59, 15);
            lbl_enterprise.TabIndex = 13;
            lbl_enterprise.Text = "Entreprise";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(124, 9);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(232, 30);
            label6.TabIndex = 14;
            label6.Text = "Entrez vos transactions";
            // 
            // lbl_amount_err
            // 
            lbl_amount_err.AutoSize = true;
            lbl_amount_err.ForeColor = Color.IndianRed;
            lbl_amount_err.Location = new Point(148, 223);
            lbl_amount_err.Name = "lbl_amount_err";
            lbl_amount_err.Size = new Size(192, 15);
            lbl_amount_err.TabIndex = 15;
            lbl_amount_err.Text = "Entrez une valeur numérique valide";
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 255, 255);
            ClientSize = new Size(478, 363);
            Controls.Add(lbl_amount_err);
            Controls.Add(label6);
            Controls.Add(lbl_enterprise);
            Controls.Add(lbl_montant);
            Controls.Add(lbl_date);
            Controls.Add(txt_cat);
            Controls.Add(lbl_category);
            Controls.Add(lbl_description);
            Controls.Add(date_Transaction);
            Controls.Add(btn_addTransaction);
            Controls.Add(txt_entreprise);
            Controls.Add(txt_price);
            Controls.Add(txt_desc);
            Margin = new Padding(2);
            Name = "TransactionForm";
            Text = "Ajoutez vos transactions";
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
        private Label lbl_description;
        private Label lbl_category;
        private ComboBox txt_cat;
        private Label lbl_date;
        private Label lbl_montant;
        private Label lbl_enterprise;
        private Label label6;
        private Label lbl_amount_err;
    }
}