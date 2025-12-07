namespace WinFormsApp1
{
    public partial class Stromverbrauch : Form
    {
        public Stromverbrauch()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

              

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            WertBox.Text = Convert.ToString(EingabeWert.TextAlign);
        }
    }
}
