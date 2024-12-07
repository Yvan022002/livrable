namespace livrable
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            panelAddBudget = new Panel();
            groupBox1 = new GroupBox();
            textBoxPeriod = new TextBox();
            textBoxCurrentExpenses = new TextBox();
            label13 = new Label();
            label15 = new Label();
            textBoxNotes = new TextBox();
            label16 = new Label();
            textBoxTotalBudget = new TextBox();
            label14 = new Label();
            BtnClose = new Button();
            BtnSubmitBudget = new Button();
            BtnBack = new Button();
            BtnReport = new Button();
            BtnAddBudget = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panelAddBudget.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(514, 15);
            label1.Name = "label1";
            label1.Size = new Size(201, 68);
            label1.TabIndex = 1;
            label1.Text = "Budget";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 24);
            label2.Name = "label2";
            label2.Size = new Size(92, 26);
            label2.TabIndex = 2;
            label2.Text = "Périodes";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 97);
            label3.Name = "label3";
            label3.Size = new Size(65, 26);
            label3.TabIndex = 3;
            label3.Text = "Notes";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_budget_40;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(461, 25);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(textBox6, 1, 5);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox5, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Location = new Point(58, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666718F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(514, 444);
            tableLayoutPanel1.TabIndex = 14;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(174, 369);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(337, 72);
            textBox6.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(174, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(337, 68);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 392);
            label9.Name = "label9";
            label9.Size = new Size(158, 26);
            label9.TabIndex = 15;
            label9.Text = "Budget respecté";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(174, 77);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(337, 67);
            textBox2.TabIndex = 17;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 170);
            label4.Name = "label4";
            label4.Size = new Size(165, 26);
            label4.TabIndex = 4;
            label4.Text = "Dépenses totales";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 243);
            label5.Name = "label5";
            label5.Size = new Size(123, 26);
            label5.TabIndex = 5;
            label5.Text = "Budget total";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 316);
            label10.Name = "label10";
            label10.Size = new Size(110, 26);
            label10.TabIndex = 21;
            label10.Text = "Différence";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(174, 223);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(337, 67);
            textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(174, 296);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(337, 67);
            textBox5.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(174, 150);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(337, 67);
            textBox3.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 66);
            comboBox1.MaxDropDownItems = 12;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 34);
            comboBox1.TabIndex = 17;
            // 
            // panelAddBudget
            // 
            panelAddBudget.BackColor = SystemColors.ActiveCaption;
            panelAddBudget.Controls.Add(groupBox1);
            panelAddBudget.Controls.Add(BtnClose);
            panelAddBudget.Controls.Add(BtnSubmitBudget);
            panelAddBudget.Location = new Point(163, 64);
            panelAddBudget.Name = "panelAddBudget";
            panelAddBudget.Size = new Size(996, 642);
            panelAddBudget.TabIndex = 18;
            panelAddBudget.Visible = false;
            panelAddBudget.Paint += panelAddBudget_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxPeriod);
            groupBox1.Controls.Add(textBoxCurrentExpenses);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(textBoxNotes);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(textBoxTotalBudget);
            groupBox1.Controls.Add(label14);
            groupBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(60, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(870, 490);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrer les informations sur votre budget";
            // 
            // textBoxPeriod
            // 
            textBoxPeriod.Font = new Font("Segoe UI", 12F);
            textBoxPeriod.Location = new Point(54, 215);
            textBoxPeriod.Name = "textBoxPeriod";
            textBoxPeriod.Size = new Size(202, 34);
            textBoxPeriod.TabIndex = 0;
            textBoxPeriod.TextChanged += textBoxPeriod_TextChanged;
            // 
            // textBoxCurrentExpenses
            // 
            textBoxCurrentExpenses.Font = new Font("Segoe UI", 12F);
            textBoxCurrentExpenses.Location = new Point(54, 371);
            textBoxCurrentExpenses.Name = "textBoxCurrentExpenses";
            textBoxCurrentExpenses.Size = new Size(202, 34);
            textBoxCurrentExpenses.TabIndex = 2;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(100, 170);
            label13.Name = "label13";
            label13.Size = new Size(104, 26);
            label13.TabIndex = 6;
            label13.Text = "Périodes*";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(63, 325);
            label15.Name = "label15";
            label15.Size = new Size(177, 26);
            label15.TabIndex = 8;
            label15.Text = "Dépenses totales*";
            // 
            // textBoxNotes
            // 
            textBoxNotes.Font = new Font("Segoe UI", 12F);
            textBoxNotes.Location = new Point(584, 215);
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.Size = new Size(202, 34);
            textBoxNotes.TabIndex = 1;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.None;
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(622, 325);
            label16.Name = "label16";
            label16.Size = new Size(135, 26);
            label16.TabIndex = 9;
            label16.Text = "Budget total*";
            // 
            // textBoxTotalBudget
            // 
            textBoxTotalBudget.Font = new Font("Segoe UI", 12F);
            textBoxTotalBudget.Location = new Point(584, 371);
            textBoxTotalBudget.Name = "textBoxTotalBudget";
            textBoxTotalBudget.Size = new Size(202, 34);
            textBoxTotalBudget.TabIndex = 3;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(644, 170);
            label14.Name = "label14";
            label14.Size = new Size(65, 26);
            label14.TabIndex = 7;
            label14.Text = "Notes";
            // 
            // BtnClose
            // 
            BtnClose.BackColor = SystemColors.Menu;
            BtnClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnClose.ImageAlign = ContentAlignment.TopRight;
            BtnClose.Location = new Point(60, 564);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(87, 39);
            BtnClose.TabIndex = 13;
            BtnClose.Text = "Fermer";
            BtnClose.UseVisualStyleBackColor = false;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnSubmitBudget
            // 
            BtnSubmitBudget.BackColor = SystemColors.Menu;
            BtnSubmitBudget.Location = new Point(833, 561);
            BtnSubmitBudget.Name = "BtnSubmitBudget";
            BtnSubmitBudget.Size = new Size(97, 42);
            BtnSubmitBudget.TabIndex = 10;
            BtnSubmitBudget.Text = "Enregistrer";
            BtnSubmitBudget.UseVisualStyleBackColor = false;
            BtnSubmitBudget.Click += BtnSubmitBudget_Click;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(72, 727);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(81, 33);
            BtnBack.TabIndex = 19;
            BtnBack.Text = "Retour";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnReport
            // 
            BtnReport.ImageAlign = ContentAlignment.MiddleRight;
            BtnReport.Location = new Point(1115, 727);
            BtnReport.Name = "BtnReport";
            BtnReport.Size = new Size(83, 33);
            BtnReport.TabIndex = 20;
            BtnReport.Text = "Rapport";
            BtnReport.UseVisualStyleBackColor = true;
            // 
            // BtnAddBudget
            // 
            BtnAddBudget.ImageAlign = ContentAlignment.MiddleRight;
            BtnAddBudget.Location = new Point(1075, 41);
            BtnAddBudget.Name = "BtnAddBudget";
            BtnAddBudget.Size = new Size(123, 42);
            BtnAddBudget.TabIndex = 21;
            BtnAddBudget.Text = "Ajouter Budget";
            BtnAddBudget.UseVisualStyleBackColor = true;
            BtnAddBudget.Click += BtnAddBudget_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(72, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 566);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sélectionne une période";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(565, 118);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(633, 566);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informations sur votre budget";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(label1);
            panelMain.Controls.Add(panelAddBudget);
            panelMain.Controls.Add(groupBox3);
            panelMain.Controls.Add(pictureBox1);
            panelMain.Controls.Add(groupBox2);
            panelMain.Controls.Add(BtnBack);
            panelMain.Controls.Add(BtnAddBudget);
            panelMain.Controls.Add(BtnReport);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1277, 772);
            panelMain.TabIndex = 24;
            panelMain.Paint += panelMain_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 255, 255);
            ClientSize = new Size(1277, 772);
            Controls.Add(panelMain);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelAddBudget.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label4;
        private Label label9;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox6;
        private Label label10;
        private ComboBox comboBox1;
        private Panel panelAddBudget;
        private TextBox textBoxTotalBudget;
        private TextBox textBoxCurrentExpenses;
        private TextBox textBoxNotes;
        private TextBox textBoxPeriod;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button BtnSubmitBudget;
        private Button BtnBack;
        private Button BtnReport;
        private Button BtnAddBudget;
        private Button BtnClose;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Panel panelMain;
    }
}