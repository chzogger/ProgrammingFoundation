namespace Aufgabe_A4_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double zahl1;
        double zahl2;
        double ergebnis = 0;
        char MeinOperand;



        private void Number1_TextChanged(object sender, EventArgs e)
        {
            zahl1 = Convert.ToInt32(Number1.Text);
        }

        private void Number2_TextChanged(object sender, EventArgs e)
        {
            zahl2 = Convert.ToInt32(Number2.Text);
        }

        private void OperandBox_TextChanged(object sender, EventArgs e)
        {
            if (OperandBox.Text != " ")
            {
                MeinOperand = Convert.ToChar(OperandBox.Text);

            }
            
        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {

            

            switch (MeinOperand)
            {
                case '+':
                    ergebnis = zahl1 + zahl2;
                    break;
                case '-':
                    ergebnis = zahl1 - zahl2;
                    break;
                case '*':
                    ergebnis = zahl1 * zahl2;
                    break;
                case '/':
                    ergebnis = (zahl1 / zahl2);
                    break;



            }

            ResultBox.Text = ergebnis.ToString();

        }
    }
}
