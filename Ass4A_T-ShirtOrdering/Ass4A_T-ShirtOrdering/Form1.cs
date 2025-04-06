namespace Ass4A_T_ShirtOrdering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int numoft = 0;
            double price = 0;

            if (radioButton1.Checked)
            {
                price = 125;
            }
            else if (radioButton2.Checked)
            {
                price = 175;
            }
            else if (radioButton3.Checked)
            {
                price = 250;
            }
            else
            {
                MessageBox.Show("Please select a T-shirt size.");
            }


            if (textBox1.Text.Length > 0)
            {
                numoft = Convert.ToInt32(textBox1.Text);
                //MessageBox.Show(numoft.ToString());
            }
            else
            {
                MessageBox.Show("Please enter no of T-shirt.");
            }
            price *= numoft;

            if (textBox2.Text == "TRUEBLUE")
            {
                price = price - (price* 0.10);
            }

            price = price + (price * 0.09);
            

            textBox3.Text = "Rs : " + price.ToString();
        }
    }
}
