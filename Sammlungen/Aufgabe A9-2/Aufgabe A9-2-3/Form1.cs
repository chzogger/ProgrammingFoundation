namespace Aufgabe_A9_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] data;
        private int[] dataCopy;


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtData_Click(object sender, EventArgs e)
        {
            data = new int[10];
            dataCopy = new int[10];

            Random r = new Random();

            for (int x = 0; x < 10; x++)
            {
                data[x] = r.Next(-10, 11);
            }

            foreach (int value in data)
            {
                BxData.Text += Convert.ToString(value) + ", ";
            }





        }

        private void BtCopy_Click(object sender, EventArgs e)
        {

            int y = 9;

            for (int x = 0; x < 10; x++)
            {                
                dataCopy[y] = data[x];
                y--;
            }


            foreach (int value in dataCopy)
            {
                BxCopy.Text += Convert.ToString(value) + ", ";

            }
                
        }
    }
}
