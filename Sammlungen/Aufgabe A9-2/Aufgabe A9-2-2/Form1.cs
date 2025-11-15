namespace Aufgabe_A9_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] MeineListe;
        private int MyIndex;
        private int counter = 1;

        public void BtnGenerate_Click(object sender, EventArgs e)
        {

            MeineListe = new int[Convert.ToInt32(BxSize.Text)];
            Random r = new Random();
            for (int x = 0; x < MeineListe.Length; x++)
            {
                MeineListe[x] = r.Next(0, Convert.ToInt32(BxSize.Text));
            }


            BtnGenerate.Enabled = false;

        }

        private void IndexAusgeben_Click(object sender, EventArgs e)
        {

            MyIndex = Convert.ToInt32(BxIndex.Text);

            BxValue.Text = Convert.ToString(MeineListe[MyIndex]);


            if (Convert.ToInt32(BxIndex.Text) < MeineListe.Length)
            {
                string _Index = Convert.ToString(BxIndex.Text);
                string _Wert = Convert.ToString(MeineListe[MyIndex]);

                BxOutput.Text += Convert.ToString(counter) + ". Zugriff, gewählter Index: " + _Index + " / Wert auf Index: " + _Wert + System.Environment.NewLine;
                counter++;
            }

            if (Convert.ToInt32(BxIndex.Text) >= MeineListe.Length)
            {
                string _Index = Convert.ToString(BxIndex.Text);

                MessageBox.Show("Geben Sie einen kleineren Index ein");
            }




        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BxSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
