namespace Aufgabe_A11_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Product[] products = new Product[5];
        int ProductCounter = 0;
       



        private void TxBoxManage_TextChanged(object sender, EventArgs e)
        {
            

        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            products[ProductCounter] = new Product();
            products[ProductCounter].name = TxtName.Text;
            products[ProductCounter].retailPrice = Convert.ToDouble(TxtVKP.Text);
            products[ProductCounter].purchasingPrice = Convert.ToDouble(TxtEKP.Text);
            ProductCounter++;


            
            LbLProducts.Text = "Gespeicherte Produkte:" + ProductCounter;
            

            TxtEKP.Text = "";
            TxtName.Text = "";
            TxtVKP.Text = "";
            TxBoxManage.Text = "";
        }




       

       

        private void Tab2_Selected(object sender, TabControlEventArgs e)
        {
            for (int i = 0; i < ProductCounter; i++)
            {
                TxBoxManage.Text += products[i].ShowValues() ;

            }

        }



        private void Tab2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
