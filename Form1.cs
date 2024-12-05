namespace livrable
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        // Méthode pour dessiner le box shadow
        private void PanelWithShadow_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Dessiner un "shadow" en arrière-plan (en décalant un peu)
            var shadowColor = Color.FromArgb(50, 0, 0, 0); // Ombre transparente
            var shadowRectangle = new Rectangle(10, 10, panel_report.Width, panel_report.Height);
            g.FillRectangle(new SolidBrush(shadowColor), shadowRectangle);

            // Dessiner le panel principal sans ombre
            var mainRectangle = new Rectangle(0, 0, panel_report.Width, panel_report.Height);
            g.FillRectangle(new SolidBrush(panel_report.BackColor), mainRectangle);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
