namespace Aufgabe_A5_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int RedColor;
        int GreenColor;
        int BlueColor;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Unchecked)
            {
                VerticalScroll.Visible = false;       

            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
            






        private void RedBar_Scroll(object sender, EventArgs e)
        {
            RedColor = RedBar.Value;
            if (checkBox1.Checked)
            {

                ColorPanel.BackColor = Color.FromArgb(RedColor, BlueColor, GreenColor);
            }
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            GreenColor = GreenBar.Value;
            if (checkBox2.Checked)
            {

                ColorPanel.BackColor = Color.FromArgb(RedColor, BlueColor, GreenColor);
            }
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            BlueColor = BlueBar.Value;
            if (checkBox3.Checked)
            {
                ColorPanel.BackColor = Color.FromArgb(RedColor, BlueColor, GreenColor);
            }
        
        }

        private void ColorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorPanel.BackColor = Color.FromArgb(RedColor, BlueColor, GreenColor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }
}
