namespace Aufgabe_A4_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Number1_ValueChanged(object sender, EventArgs e)
        {
            Number1.BackColor = default(Color);
            Number2.BackColor = default(Color);

        }

        private void Number2_ValueChanged(object sender, EventArgs e)
        {
            Number2.BackColor = default(Color);
            Number1.BackColor = default(Color);
        }

        private void AusführenButton_Click(object sender, EventArgs e)
        {
            if (Number1.Value > Number2.Value)
            {
                Number1.BackColor = Color.Green;
                AusgabeFeld.Text = "Zahl 1 ist grösser";
            }

            else if (Number1.Value < Number2.Value)
            {
                Number2.BackColor = Color.Green;
                AusgabeFeld.Text = "Zahl 2 ist grösser";
            }

            else 
            
            {
                Number1.BackColor = Color.Red;
                Number2.BackColor = Color.Red;

                AusgabeFeld.Text = "Du Depp hast es wieder geschafft!";
            }
        }
    }
}
