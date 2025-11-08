using System.Web;

namespace Wichteln_Auslosung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        enum Person
        {
            Florian = 1,
            Lia,
            Andreas,
            Valerie,
            Grosi,
            Marco,
            Delia,
            Sarah
        }

        int Z = 0;

        private void Auslosen(string Name)
        {
            Random N = new Random();
            N.Next(1, 8);


            
        }
        

        private void BtFlo_Click(object sender, EventArgs e)
        {
            Random N = new Random();
            int Z = N.Next(1, 9);

            do 
            {
               N = new Random();
               Z = N.Next(1, 9);
            }

            while (Z == ((int)Person.Florian));

            TxtPerson.Text = ((Person)Z).ToString();           
        

        }

        private void BtLia_Click(object sender, EventArgs e)
        {

            Random N = new Random();
            int Z = N.Next(1, 9);

            do
            {
                N = new Random();
                Z = N.Next(1, 9);
            }

            while (Z == ((int)Person.Lia));

            TxtPerson.Text = ((Person)Z).ToString();
        }

        private void BtAndi_Click(object sender, EventArgs e)
        {

            Random N = new Random();
            int Z = N.Next(1, 9);

            do
            {
                N = new Random();
                Z = N.Next(1, 9);
            }

            while (Z == ((int)Person.Andreas));

            TxtPerson.Text = ((Person)Z).ToString();

        }

        private void BtMam_Click(object sender, EventArgs e)
        {
            Random N = new Random();
            int Z = N.Next(1, 9);

            do
            {
                N = new Random();
                Z = N.Next(1, 9);
            }

            while (Z == ((int)Person.Valerie));

            TxtPerson.Text = ((Person)Z).ToString();

        }

        private void BtGrosi_Click(object sender, EventArgs e)
        {
            Random N = new Random();
            int Z = N.Next(1, 9);

            do
            {
                N = new Random();
                Z = N.Next(1, 9);
            }

            while (Z == ((int)Person.Grosi));

            TxtPerson.Text = ((Person)Z).ToString();

        }

        private void BtMarco_Click(object sender, EventArgs e)
        {
            Random N = new Random();
            int Z = N.Next(1, 9);

            do
            {
                N = new Random();
                Z = N.Next(1, 9);
            }

            while (Z == ((int)Person.Marco));

            TxtPerson.Text = ((Person)Z).ToString();

        }

        private void BtDelia_Click(object sender, EventArgs e)
        {
            Random N = new Random();
            int Z = N.Next(1, 9);

            do
            {
                N = new Random();
                Z = N.Next(1, 9);
            }

            while (Z == ((int)Person.Delia));

            TxtPerson.Text = ((Person)Z).ToString();

        }

        private void BtSarah_Click(object sender, EventArgs e)
        {
            Random N = new Random();
            int Z = N.Next(1, 9);

            do
            {
                N = new Random();
                Z = N.Next(1, 9);
            }

            while (Z == ((int)Person.Sarah));

            TxtPerson.Text = ((Person)Z).ToString();

        }
    }
}
