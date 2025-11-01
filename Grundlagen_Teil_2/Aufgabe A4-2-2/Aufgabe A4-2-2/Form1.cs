using System.Diagnostics.Metrics;

namespace Aufgabe_A4_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

           int Colour = 0;
                

        private void switch_Click(object sender, EventArgs e)
        {
            if ((int)Colour == 0)
            {
                
                UpperLight.BackColor = Color.Red;
                Colour++;
            }

            else if (Colour == 1)
            {
                
                MiddleLight.BackColor = Color.Orange;
                Colour++;
            }

            else if (Colour == 2)
            {
                
                UpperLight.BackColor = Color.DimGray;
                MiddleLight.BackColor = Color.DimGray;
                BottomLight.BackColor = Color.Green;
                Colour++;
            }

            else if(Colour == 3)
            {

                MiddleLight.BackColor = Color.Orange;
                BottomLight.BackColor = Color.DimGray;
                Colour++;
            }

            else if(Colour == 4)
            {
                MiddleLight.BackColor = Color.DimGray;
                BottomLight.BackColor = Color.DimGray;
                UpperLight.BackColor = Color.Red;
                Colour=0;
            }






        }

        private void UpperLight_Click(object sender, EventArgs e)
        {

        }
        private void MiddleLight_Click(object sender, EventArgs e)
        {

        }
        private void BottomLight_Click(object sender, EventArgs e)
        {

        }

        
    }
}
