namespace Aufgabe_A4_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal Zahl_A;
        decimal Zahl_B;

       
        private void HokusBokus_Click(object sender, EventArgs e)
        {
            if (Zahl_A > Zahl_B)
            {
                LabelErgebnis.Text = "Zahl A ist grösser";
            }

            else if (Zahl_B > Zahl_A)
            {
                LabelErgebnis.Text = "Zahl B ist grösser";
            }

            else
            {
                LabelErgebnis.Text = "Du Depp, hast zwei gelich gorsse Zahlen eingegeebn";

            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Zahl_A = numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Zahl_B = numericUpDown2.Value;
        }
    }
}
