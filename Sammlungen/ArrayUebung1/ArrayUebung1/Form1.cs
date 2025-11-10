using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArrayUebung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] MeineListe = new int[10];
        string MeinArray = " ";
        int L = 0;



        private void MyNumberAppend_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnHinzufuegen_Click(object sender, EventArgs e)
        {

            MeineListe[L] = Convert.ToInt32(MyNumberAppend.Value);       
            
            MeinArray += Convert.ToString(MeineListe[L]) + System.Environment.NewLine;

            MyNumberAppend.Value = default;
            L++;

        }

        private void BtnAusgeben_Click(object sender, EventArgs e)
        {
            Ausgabeliste.Text = MeinArray;

        }

        private void Ausgabeliste_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
