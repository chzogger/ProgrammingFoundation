namespace WinFormsApp1
{
    public partial class KostenBerechnen : Form
    {

        double Kosten;
        public KostenBerechnen()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Ausgabewert_TextChanged(object sender, EventArgs e)
        {

        }

        private void BerechnenButton_Click(object sender, EventArgs e)
        {
            Ausgabewert.Text = "Die Kosten belaufen sich auf: " + Convert.ToString(Kosten) + ".- CHF";
        }

        private void Eingabewert_ValueChanged(object sender, EventArgs e)
        {

            Kosten = Math.Round((double)Eingabewert.Value * 0.277, 2);
        }
    }
}
