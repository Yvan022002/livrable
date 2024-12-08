namespace livrable
{
    partial class OverviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            depensesProviderBindingSource = new BindingSource(components);
            group_transactions = new GroupBox();
            btn_transactions = new Button();
            datagrid_transactions = new DataGridView();
            group_categories = new GroupBox();
            btn_categories = new Button();
            group_budget = new GroupBox();
            lbl_budget = new Label();
            listbox_categories = new ListBox();
            ((System.ComponentModel.ISupportInitialize)depensesProviderBindingSource).BeginInit();
            group_transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid_transactions).BeginInit();
            group_categories.SuspendLayout();
            group_budget.SuspendLayout();
            SuspendLayout();
            // 
            // depensesProviderBindingSource
            // 
            depensesProviderBindingSource.DataSource = typeof(model.DepensesProvider);
            // 
            // group_transactions
            // 
            group_transactions.Controls.Add(btn_transactions);
            group_transactions.Controls.Add(datagrid_transactions);
            group_transactions.Font = new Font("Segoe UI", 12F);
            group_transactions.Location = new Point(33, 32);
            group_transactions.Name = "group_transactions";
            group_transactions.Size = new Size(934, 467);
            group_transactions.TabIndex = 2;
            group_transactions.TabStop = false;
            group_transactions.Text = "Transactions";
            // 
            // btn_transactions
            // 
            btn_transactions.Font = new Font("Segoe UI", 14F);
            btn_transactions.Location = new Point(347, 398);
            btn_transactions.Name = "btn_transactions";
            btn_transactions.Size = new Size(239, 63);
            btn_transactions.TabIndex = 1;
            btn_transactions.Text = "Ajouter";
            btn_transactions.UseVisualStyleBackColor = true;
            btn_transactions.Click += btn_transctions_Click;
            // 
            // datagrid_transactions
            // 
            datagrid_transactions.AllowUserToAddRows = false;
            datagrid_transactions.AllowUserToDeleteRows = false;
            datagrid_transactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid_transactions.Location = new Point(26, 31);
            datagrid_transactions.Name = "datagrid_transactions";
            datagrid_transactions.ReadOnly = true;
            datagrid_transactions.Size = new Size(883, 361);
            datagrid_transactions.TabIndex = 0;
            // 
            // group_categories
            // 
            group_categories.Controls.Add(listbox_categories);
            group_categories.Controls.Add(btn_categories);
            group_categories.Font = new Font("Segoe UI", 12F);
            group_categories.Location = new Point(1020, 32);
            group_categories.Name = "group_categories";
            group_categories.Size = new Size(576, 467);
            group_categories.TabIndex = 3;
            group_categories.TabStop = false;
            group_categories.Text = "Catégories";
            // 
            // btn_categories
            // 
            btn_categories.Font = new Font("Segoe UI", 14F);
            btn_categories.Location = new Point(171, 398);
            btn_categories.Name = "btn_categories";
            btn_categories.Size = new Size(239, 63);
            btn_categories.TabIndex = 2;
            btn_categories.Text = "Ajouter";
            btn_categories.UseVisualStyleBackColor = true;
            btn_categories.Click += btn_categories_Click;
            // 
            // group_budget
            // 
            group_budget.Controls.Add(lbl_budget);
            group_budget.Font = new Font("Segoe UI", 12F);
            group_budget.Location = new Point(33, 517);
            group_budget.Name = "group_budget";
            group_budget.Size = new Size(1563, 211);
            group_budget.TabIndex = 4;
            group_budget.TabStop = false;
            group_budget.Text = "Budget";
            // 
            // lbl_budget
            // 
            lbl_budget.Font = new Font("Segoe UI", 24F);
            lbl_budget.Location = new Point(610, 13);
            lbl_budget.Name = "lbl_budget";
            lbl_budget.Size = new Size(340, 195);
            lbl_budget.TabIndex = 0;
            lbl_budget.Text = "0/1000";
            lbl_budget.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listbox_categories
            // 
            listbox_categories.ItemHeight = 21;
            listbox_categories.Location = new Point(21, 31);
            listbox_categories.Name = "listbox_categories";
            listbox_categories.Size = new Size(537, 361);
            listbox_categories.TabIndex = 0;
            // 
            // OverviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(group_budget);
            Controls.Add(group_categories);
            Controls.Add(group_transactions);
            Name = "OverviewControl";
            Size = new Size(1686, 777);
            ((System.ComponentModel.ISupportInitialize)depensesProviderBindingSource).EndInit();
            group_transactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid_transactions).EndInit();
            group_categories.ResumeLayout(false);
            group_budget.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource depensesProviderBindingSource;
        private GroupBox group_transactions;
        private Button btn_transactions;
        private DataGridView datagrid_transactions;
        private GroupBox group_categories;
        private Button btn_categories;
        private GroupBox group_budget;
        private Label lbl_budget;
        private ListBox listbox_categories;
    }
}
