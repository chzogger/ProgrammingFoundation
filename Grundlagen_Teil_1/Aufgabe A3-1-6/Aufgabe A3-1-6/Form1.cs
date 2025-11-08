namespace Aufgabe_A3_1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*enum BinaryValue : int
        {
            Bit1 = 1,
            Bit2 = 2,
            Bit3 = 4,
            Bit4 = 8,
            Bit5 = 16,
            Bit6 = 32,
            Bit7 = 64,
            Bit8 = 128,
        }*/



        int Bit1 = 1;
        int Bit2 = 2;
        int Bit3 = 4;
        int Bit4 = 16;
        int Bit5 = 32;
        int Bit6 = 64;
        int Bit7 = 128;
        int Bit8 = 256;

        int result_byte1 = 0;
        int result_byte2 = 0;




        private void Bit1_Byte1_ValueChanged(object sender, EventArgs e)
        {
            result_byte1 += Bit1;
            resultLabelByte1.Text = "Dezimal: " + Convert.ToString(result_byte1);
        }

        private void Bit2_Byte1_ValueChanged_1(object sender, EventArgs e)
        {
            result_byte1 += Bit2;
            resultLabelByte1.Text = "Dezimal: " + Convert.ToString(result_byte1);
        }

        private void Bit3_Byte1_ValueChanged(object sender, EventArgs e)
        {
            result_byte1 += Bit3;
            resultLabelByte1.Text = "Dezimal: " + Convert.ToString(result_byte1);
        }

       
        private void Bit4_Byte1_ValueChanged_1(object sender, EventArgs e)
        {
            result_byte1 += Bit4;
            resultLabelByte1.Text = "Dezimal: " + Convert.ToString(result_byte1);
        }

        private void Bit5_Byte1_ValueChanged(object sender, EventArgs e)
        {
            result_byte1 += Bit5;
            resultLabelByte1.Text = "Dezimal: " + Convert.ToString(result_byte1);
        }

        private void Bit6_Byte1_ValueChanged(object sender, EventArgs e)
        {
            result_byte1 += Bit6;
            resultLabelByte1.Text = "Dezimal: " + Convert.ToString(result_byte1);
        }

        private void Bit7_Byte1_ValueChanged(object sender, EventArgs e)
        {
            result_byte1 += Bit7;
            resultLabelByte1.Text = "Dezimal: " + Convert.ToString(result_byte1);
        }

        private void Bit8_Byte1_ValueChanged(object sender, EventArgs e)
        {
            result_byte1 += Bit8;
            resultLabelByte1.Text = "Dezimal: " + Convert.ToString(result_byte1);
        }



        private void Bit1_Byte2_ValueChanged_1(object sender, EventArgs e)
        {
            result_byte2 += Bit1;
            resultLabelByte2.Text = "Dezimal: " + Convert.ToString(result_byte2);
        }

        private void Bit2_Byte2_ValueChanged_1(object sender, EventArgs e)
        {
            result_byte2 += Bit2;
            resultLabelByte2.Text = "Dezimal: " + Convert.ToString(result_byte2);
        }

        private void Bit3_Byte2_ValueChanged(object sender, EventArgs e)
        {
            result_byte2 += Bit3;
            resultLabelByte2.Text = "Dezimal: " + Convert.ToString(result_byte2);
        }

        private void Bit4_Byte2_ValueChanged(object sender, EventArgs e)
        {
            result_byte2 += Bit4;
            resultLabelByte2.Text = "Dezimal: " + Convert.ToString(result_byte2);
        }

        private void Bit5_Byte2_ValueChanged(object sender, EventArgs e)
        {
            result_byte2 += Bit5;
            resultLabelByte2.Text = "Dezimal: " + Convert.ToString(result_byte2);
        }

        private void Bit6_Byte2_ValueChanged(object sender, EventArgs e)
        {
            result_byte2 += Bit6;
            resultLabelByte2.Text = "Dezimal: " + Convert.ToString(result_byte2);
        }

        private void Bit7_Byte2_ValueChanged(object sender, EventArgs e)
        {
            result_byte2 += Bit7;
            resultLabelByte2.Text = "Dezimal: " + Convert.ToString(result_byte2);
        }

        private void Bit8_Byte2_ValueChanged(object sender, EventArgs e)
        {
            result_byte2 += Bit8;
            resultLabelByte2.Text = "Dezimal: " + Convert.ToString(result_byte2);
        }

        
    }
}
