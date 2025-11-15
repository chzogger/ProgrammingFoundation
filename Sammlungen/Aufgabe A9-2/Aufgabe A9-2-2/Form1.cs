namespace Aufgabe_A9_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] MeineListe;
        

        public void BtnGenerate_Click(object sender, EventArgs e)
        {
            
            MeineListe = new int[Convert.ToInt32(BxSize.Text)];
            Random r = new Random();
            for (int x = 0; x < MeineListe.Length; x++)
            {
                MeineListe[x] = r.Next(0, Convert.ToInt32(BxSize.Text));
            }



        }

        private void IndexAusgeben_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(BxIndex.Text) >= MeineListe.Length)
            {
                MessageBox.Show("Geben Sie einen kleineren Index ein");


            }

            if (Convert.ToInt32(BxIndex.Text) < MeineListe.Length)
            {
                BxOutput.Text += Convert.ToString(MeineListe[Convert.ToInt32(BxIndex.Text)] + System.Environment.NewLine);

            }

            

        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BxSize_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
