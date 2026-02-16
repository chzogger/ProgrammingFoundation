namespace Guess_the_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public int _number;
        public int guess;





        private void BxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            guess = Convert.ToInt16(BxNumber.Text);

            if (guess > _number)
            {
                LblOutpt.Text = "Die gesuchte Zahl ist kleiner";
            }

            else if (guess < _number)
            {
                LblOutpt.Text = "Die gesuchte Zahl ist grösser";

            }

            else if (guess == _number)
            {
                LblOutpt.Text = "Herzlichen Glückwunsch!" + "\r\n" + "Die gesuchte Zahl: " + _number.ToString();
            }

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int number = r.Next(1,20);
            _number = number;

        }
    }
}
