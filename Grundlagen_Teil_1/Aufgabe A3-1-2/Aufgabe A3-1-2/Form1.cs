namespace Aufgabe_A3_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum MonthOfYear : int
        {
            Januar = 1,
            Februar = 2,
            März = 3,
            April = 4,
            Mai = 5,
            Juni = 6,
            Juli = 7,
            August = 8,
            September = 9,
            Oktober = 10,
            November = 11,
            Dezember = 12,
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MyMonth.Value);

            MonthLabel.Text = "Sie haben den Monat " + Convert.ToString((MonthOfYear)x) + " ausgewählt ☺";

        }

        private void MyMonth_ValueChanged(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(MyMonth.Value);

            MonthLabel.Text = "Sie haben den Monat " + Convert.ToString((MonthOfYear)x) + " ausgewählt ☺";
          

        }

    }
}
