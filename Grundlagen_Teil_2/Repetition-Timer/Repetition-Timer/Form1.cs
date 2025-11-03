namespace Repetition_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int _sec = 0;



        private void MyTimer_Tick(object sender, EventArgs e)
        {
            _sec += 1;
            if (_sec < 2)
                Stoppuhr.Text = _sec.ToString() + " Sekunde vergangen";
            else
                Stoppuhr.Text = _sec.ToString() + " Sekunden vergangen";


        }

        private void StartStopButton_Click(object sender, EventArgs e)
        {
            if (MyTimer.Enabled)
            {
                MyTimer.Enabled = true;
                MyTimer.Stop();
                _sec = 0;
                StartStopButton.Text = "Start!";
                Stoppuhr.Text = _sec.ToString() + " Sekunden vergangen";


            }


            else
            {
                MyTimer.Start();                           
                StartStopButton.Text = "Stop!";
               
            }


        }


        private void EvenNumbers_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
