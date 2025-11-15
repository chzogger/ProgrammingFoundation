using System.Reflection.Metadata.Ecma335;

namespace Aufgabe_A9_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateList();
        }

        int[] MeineZahlen = new int[10];
        Random r = new Random();
        private int summe = 0;

        public void GenerateList()
        {
            for (int y = 0; y < MeineZahlen.Length; y++)
            {
                int Zufallszahl = r.Next(0, 101);
                MeineZahlen[y] = Zufallszahl;
                BxNumbers.Text += Convert.ToString(Zufallszahl) + ", ";
            }
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnBiggestNr_Click(object sender, EventArgs e)
        {
            bool Sorted = false;
            while (Sorted == false)
            {
                Sorted = true;
                for (int x = 0; x < MeineZahlen.Length - 1; x++)
                {
                    if (MeineZahlen[x] < MeineZahlen[x + 1])
                    {
                        int temp = MeineZahlen[x + 1];
                        MeineZahlen[x + 1] = MeineZahlen[x];
                        MeineZahlen[x] = temp;
                        Sorted = false;
                    }

                }

            }
            LblBiggestNr.Text = Convert.ToString(MeineZahlen[0]);

        }

        private void BtnSmallestNr_Click(object sender, EventArgs e)
        {
            bool Sorted = false;
            while (Sorted == false)
            {
                Sorted = true;
                for (int x = 0; x < MeineZahlen.Length - 1; x++)
                {
                    if (MeineZahlen[x] < MeineZahlen[x + 1])
                    {
                        int temp = MeineZahlen[x + 1];
                        MeineZahlen[x + 1] = MeineZahlen[x];
                        MeineZahlen[x] = temp;
                        Sorted = false;
                    }

                }

            }
            LblSmallest.Text = Convert.ToString(MeineZahlen[9]);

        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            foreach (int number in MeineZahlen)
            {                
                summe = summe + number;
                
            }
            LblAverage.Text = Convert.ToString(summe / MeineZahlen.Length);




        }
    }
}
