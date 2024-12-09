namespace livrable
{
    partial class BudgetControl
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
            group_add_budget = new GroupBox();
            label5 = new Label();
            lbl_name = new Label();
            label3 = new Label();
            label2 = new Label();
            box_name = new TextBox();
            lbl_err = new Label();
            box_amount = new TextBox();
            picker_end = new DateTimePicker();
            picker_start = new DateTimePicker();
            btn_add_budget = new Button();
            data_budgets = new DataGridView();
            groupBox2 = new GroupBox();
            lbl_selected_budget = new Label();
            label1 = new Label();
            label4 = new Label();
            group_add_budget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_budgets).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // group_add_budget
            // 
            group_add_budget.Controls.Add(label5);
            group_add_budget.Controls.Add(lbl_name);
            group_add_budget.Controls.Add(label3);
            group_add_budget.Controls.Add(label2);
            group_add_budget.Controls.Add(box_name);
            group_add_budget.Controls.Add(lbl_err);
            group_add_budget.Controls.Add(box_amount);
            group_add_budget.Controls.Add(picker_end);
            group_add_budget.Controls.Add(picker_start);
            group_add_budget.Controls.Add(btn_add_budget);
            group_add_budget.Font = new Font("Segoe UI", 12F);
            group_add_budget.Location = new Point(19, 25);
            group_add_budget.Name = "group_add_budget";
            group_add_budget.Size = new Size(607, 396);
            group_add_budget.TabIndex = 0;
            group_add_budget.TabStop = false;
            group_add_budget.Text = "Ajouter un budget";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(163, 171);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 9;
            label5.Text = "Montant";
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(187, 52);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(45, 21);
            lbl_name.TabIndex = 8;
            lbl_name.Text = "Nom";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(168, 93);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 7;
            label3.Text = "Date fin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 132);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 6;
            label2.Text = "Date début";
            // 
            // box_name
            // 
            box_name.Location = new Point(238, 49);
            box_name.Name = "box_name";
            box_name.Size = new Size(200, 29);
            box_name.TabIndex = 5;
            // 
            // lbl_err
            // 
            lbl_err.AutoSize = true;
            lbl_err.Font = new Font("Segoe UI", 10F);
            lbl_err.ForeColor = Color.IndianRed;
            lbl_err.Location = new Point(126, 228);
            lbl_err.Name = "lbl_err";
            lbl_err.Size = new Size(113, 19);
            lbl_err.TabIndex = 4;
            lbl_err.Text = "Placeholder error";
            lbl_err.Visible = false;
            // 
            // box_amount
            // 
            box_amount.Location = new Point(238, 168);
            box_amount.Name = "box_amount";
            box_amount.Size = new Size(200, 29);
            box_amount.TabIndex = 3;
            // 
            // picker_end
            // 
            picker_end.Location = new Point(238, 126);
            picker_end.Name = "picker_end";
            picker_end.Size = new Size(200, 29);
            picker_end.TabIndex = 2;
            // 
            // picker_start
            // 
            picker_start.Location = new Point(238, 87);
            picker_start.Name = "picker_start";
            picker_start.Size = new Size(200, 29);
            picker_start.TabIndex = 1;
            // 
            // btn_add_budget
            // 
            btn_add_budget.Font = new Font("Segoe UI", 12F);
            btn_add_budget.Location = new Point(229, 299);
            btn_add_budget.Name = "btn_add_budget";
            btn_add_budget.Size = new Size(105, 68);
            btn_add_budget.TabIndex = 0;
            btn_add_budget.Text = "Ajouter";
            btn_add_budget.UseVisualStyleBackColor = true;
            btn_add_budget.Click += btn_add_budget_Click;
            // 
            // data_budgets
            // 
            data_budgets.AllowUserToAddRows = false;
            data_budgets.AllowUserToDeleteRows = false;
            data_budgets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_budgets.Location = new Point(644, 38);
            data_budgets.Name = "data_budgets";
            data_budgets.ReadOnly = true;
            data_budgets.Size = new Size(1018, 381);
            data_budgets.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lbl_selected_budget);
            groupBox2.Location = new Point(20, 445);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1642, 306);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Budget sélectionné";
            // 
            // lbl_selected_budget
            // 
            lbl_selected_budget.Font = new Font("Segoe UI", 42F);
            lbl_selected_budget.Location = new Point(0, 119);
            lbl_selected_budget.Name = "lbl_selected_budget";
            lbl_selected_budget.Size = new Size(1642, 84);
            lbl_selected_budget.TabIndex = 0;
            lbl_selected_budget.Text = "0/1000";
            lbl_selected_budget.TextAlign = ContentAlignment.MiddleCenter;
            lbl_selected_budget.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(439, 15);
            label1.TabIndex = 1;
            label1.Text = "Sélectionnez une rangée dans le tableau ci-haut pour voir votre gestion du budget";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(644, 20);
            label4.Name = "label4";
            label4.Size = new Size(305, 15);
            label4.TabIndex = 3;
            label4.Text = "La sélection se fait à l'aide de la colonne la plus à gauche";
            // 
            // BudgetControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(data_budgets);
            Controls.Add(group_add_budget);
            Name = "BudgetControl";
            Size = new Size(1686, 777);
            group_add_budget.ResumeLayout(false);
            group_add_budget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_budgets).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox group_add_budget;
        private Label lbl_err;
        private TextBox box_amount;
        private DateTimePicker picker_end;
        private DateTimePicker picker_start;
        private Button btn_add_budget;
        private Label label5;
        private Label lbl_name;
        private Label label3;
        private Label label2;
        private TextBox box_name;
        private DataGridView data_budgets;
        private GroupBox groupBox2;
        private Label lbl_selected_budget;
        private Label label1;
        private Label label4;
    }
}
