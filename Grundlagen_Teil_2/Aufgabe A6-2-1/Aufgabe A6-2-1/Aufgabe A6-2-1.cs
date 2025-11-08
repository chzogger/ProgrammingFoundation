namespace Aufgabe_A6_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Zufallszahl = 0;
        double newNumber = 0;
        double Zwischenresultat = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (newNumber > 1)
            {

                double divide = newNumber / 2;
                newNumber = divide;
                NumbersOutput.AppendText((Zufallszahl) + " / " + Convert.ToString(2) + " = " + Convert.ToString(divide) + Environment.NewLine);
                
                

            }

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            NumbersOutput.Text = default;
            Random r = new Random();
             Zufallszahl = r.Next(10, 10000);
            newNumber = Zufallszahl;

            MyNumber.Text = Convert.ToString(Zufallszahl);

        }



        private void MyNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumbersOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
