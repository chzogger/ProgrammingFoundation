namespace Aufgabe_A4_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int width = 300;
        int height = 300;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            height = Convert.ToInt32(HeightBox.Text);

        }

        private void WidthBox_TextChanged(object sender, EventArgs e)
        {
            width = Convert.ToInt32(WidthBox.Text);

        }

        private void MyBox_Click(object sender, EventArgs e)
        {
            
        }

        private void ZeichnenButton_Click(object sender, EventArgs e)
        {
           

            if (height < 501 && width < 501)
                            

            {
                MyBox.BackColor = Color.LightSteelBlue;
                MyBox.Height = height;
                MyBox.Width = width;


                LabelWidth.Text = WidthBox.Text;
                LabelHeight.Text = HeightBox.Text;
                if (width == height)
                {
                    MyBox.BackColor = Color.Purple;

                }


            }

            else 
            
            {
                MessageBox.Show("Du Deppp hast es wieder geschafft");
            
            }

            









        }
    }
}
