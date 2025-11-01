namespace Aufgabe_A3_1
{
    public partial class Form1 : Form
    {

        enum DayofWeek : int
        {
            Montag = 1,
            Dienstag = 2,
            Mittwoch = 3,
            Donnerstag = 4,
            Freitag = 5,
            Samstag = 6,
            Sonntag = 7,
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void TextAusgabe()
        {
            labelDay.Text += ". Tag der Woche";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_monday_Click(object sender, EventArgs e)
        {
            labelDay.Text = Convert.ToString((int)DayofWeek.Montag);
            TextAusgabe();

        }

        private void button_tuesday_Click(object sender, EventArgs e)
        {
            labelDay.Text = Convert.ToString((int)DayofWeek.Dienstag);
            TextAusgabe();
        }

        private void button_wednesday_Click(object sender, EventArgs e)
        {
            labelDay.Text = Convert.ToString((int)DayofWeek.Mittwoch);
            TextAusgabe();
        }

        private void button_thursday_Click(object sender, EventArgs e)
        {
            labelDay.Text = Convert.ToString((int)DayofWeek.Donnerstag);
            TextAusgabe();
        }

        private void button_friday_Click(object sender, EventArgs e)
        {
            labelDay.Text = Convert.ToString((int)DayofWeek.Freitag);
            TextAusgabe();
        }

        private void button_saturday_Click(object sender, EventArgs e)
        {
            labelDay.Text = Convert.ToString((int)DayofWeek.Samstag);
            TextAusgabe();
        }

        private void button_sunday_Click(object sender, EventArgs e)
        {
            labelDay.Text = Convert.ToString((int)DayofWeek.Sonntag);
            TextAusgabe();
        }
    }
}
