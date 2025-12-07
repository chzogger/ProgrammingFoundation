namespace Stromkosten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Ausgabewert.Text = "Betrag: " + Convert.ToString((double)EingabeFeld.Value * 0.15) + " CHF";

        }

        private void EingabeFeld_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Ausgabe_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
