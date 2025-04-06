namespace Ass4_B_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate('+');
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate('-');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculate('*');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculate('/');
        }
        private void Calculate(char op)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = 0;

                switch (op)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/':
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        result = num1 / num2;
                        break;
                }

                label1.Text = "Result: " + result.ToString("0.##");
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter valid numbers.");
            }
        }
    }
}
