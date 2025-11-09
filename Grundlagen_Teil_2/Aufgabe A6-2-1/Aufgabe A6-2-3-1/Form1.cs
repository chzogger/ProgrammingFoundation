namespace Aufgabe_A6_2_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Zahl1 = 0;
        int Zahl2 = 0;

        int Dividend = 0;
        int Divisor = 0;

        int Rest = 0;



        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void Num1_ValueChanged(object sender, EventArgs e)
        {
            Zahl1 = Convert.ToInt32(Num1.Value);
        }

        private void Num2_ValueChanged(object sender, EventArgs e)
        {
            Zahl2 = Convert.ToInt32(Num2.Value);

        }

        private void BxggT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGgT_Click(object sender, EventArgs e)
        {
                 


            if (Zahl1 > Zahl2)
            {
                Dividend = Zahl1;
                Divisor = Zahl2;
                
            }

            if (Zahl2 > Zahl1)
            {
               Dividend = Zahl2;
                Divisor = Zahl1;
                               
            }

            if (Dividend % Divisor == 0)
            {
                BxggT.Text = Convert.ToString(Divisor);
            }

            while (Divisor != 0)
            {
                Rest = Dividend % Divisor;
                Dividend = Divisor;
                Divisor = Rest;
            }

            BxggT.Text = Convert.ToString(Dividend);



        }
    }
}
