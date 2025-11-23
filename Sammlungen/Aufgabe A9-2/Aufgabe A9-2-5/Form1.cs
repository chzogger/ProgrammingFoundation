namespace Aufgabe_A9_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Alphabet();
        }

        private int[] Zahlen = new int[1000];
        Random N = new Random();

        private void Alphabet()
        {
            for (int x = 0; x < Zahlen.Length; x++)
            {
                Zahlen[x] = N.Next(65, 91);
            }
        }



        private void BtStart_Click(object sender, EventArgs e)
        {
            TxBxNumbers.Text = Convert.ToString(Array.IndexOf(Zahlen, 65));


        }

        
    }
}
