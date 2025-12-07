namespace Aufgaben_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum _color
        {
            blond,
            brown,
            red,
            black
        }
        public class Person
        {
            public string firstname;
            public string lastname;
            public int age;
            public decimal height;
            public _color hairColor;

            public string ShowValues()
            {
                return "Vorname: " + firstname + ", Nachname: " + lastname + ", Alter: " + age + ", Haarfarbe: " + hairColor + Environment.NewLine;

            }


        }




        private void Person1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            {
                p1.firstname = "Max";
                p1.lastname = "Muster";
                p1.age = 28;
                p1.hairColor = _color.blond;
                TxtBox.Text += p1.ShowValues();
            }

            Person1.Enabled = false;
        }

        private void Person3_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            {
                p1.firstname = "Florian";
                p1.lastname = "Stettler";
                p1.age = 55;
                p1.hairColor = _color.brown;
                TxtBox.Text += p1.ShowValues();
            }
            Person3.Enabled = false;
        }

        private void Person2_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            {
                p1.firstname = "Lia";
                p1.lastname = "Gubler";
                p1.age = 25;
                p1.hairColor = _color.red;
                TxtBox.Text += p1.ShowValues();
            }
            Person2.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
