namespace Aufgabe_A6_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            Result.Text = "";
            int value = Convert.ToInt32(DezNum.Value);
            while (value != 0)
            {
                Result.Text = (value % 2) + Result.Text;
                value /= 2;
            }
        }
    }
}