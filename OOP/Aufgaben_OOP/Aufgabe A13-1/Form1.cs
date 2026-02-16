using System.Diagnostics.Metrics;

namespace Aufgabe_A13_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {         

            {
                Person p1 = new Person();
                p1.Firstname = BxFirstname.Text;
                p1.Lastname = BxLastname.Text;
                p1.Age = Convert.ToInt32(BxAge.Text);

                BxCounter.Text = Person.counter.ToString();
            }



        }
        
    }
}
