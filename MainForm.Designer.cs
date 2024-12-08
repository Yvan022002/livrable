namespace livrable
{
    partial class MainForm
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
            panel1 = new Panel();
            btn_budget = new Button();
            btn_report = new Button();
            btn_dashboard = new Button();
            lbl_page_title = new Label();
            pnl_page = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(btn_budget);
            panel1.Controls.Add(btn_report);
            panel1.Controls.Add(btn_dashboard);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 863);
            panel1.TabIndex = 0;
            // 
            // btn_budget
            // 
            btn_budget.Location = new Point(0, 202);
            btn_budget.Name = "btn_budget";
            btn_budget.Size = new Size(100, 100);
            btn_budget.TabIndex = 2;
            btn_budget.Text = "Budget";
            btn_budget.UseVisualStyleBackColor = true;
            btn_budget.Click += btn_budget_Click;
            // 
            // btn_report
            // 
            btn_report.Location = new Point(0, 101);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(100, 100);
            btn_report.TabIndex = 1;
            btn_report.Text = "Rapport";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Location = new Point(0, 0);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(100, 100);
            btn_dashboard.TabIndex = 0;
            btn_dashboard.Text = "Tableau de bord";
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // lbl_page_title
            // 
            lbl_page_title.Font = new Font("Segoe UI", 32F);
            lbl_page_title.ForeColor = SystemColors.WindowText;
            lbl_page_title.Location = new Point(107, 9);
            lbl_page_title.Name = "lbl_page_title";
            lbl_page_title.Size = new Size(1686, 60);
            lbl_page_title.TabIndex = 1;
            lbl_page_title.Text = "Page Title";
            lbl_page_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_page
            // 
            pnl_page.Location = new Point(107, 72);
            pnl_page.Name = "pnl_page";
            pnl_page.Size = new Size(1686, 777);
            pnl_page.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1804, 861);
            Controls.Add(pnl_page);
            Controls.Add(lbl_page_title);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MonArgent";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_budget;
        private Button btn_report;
        private Button btn_dashboard;
        private Label lbl_page_title;
        private Panel pnl_page;
    }
}