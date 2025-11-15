namespace Aufgabe_A9_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnStart_Click(object sender, EventArgs e)
        {
            int[] MeineZahlen = new int[20];

            Random r = new Random();

            for (int x = 0; x < 20; x++)
            {
                MeineZahlen[x] = r.Next(1, 100);
                BxNumbers.Text += Convert.ToString(MeineZahlen[x]) + System.Environment.NewLine;
            }

           



        }

        
    }
}
