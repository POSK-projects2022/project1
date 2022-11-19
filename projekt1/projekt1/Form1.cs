namespace projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button b6 = (Button)sender;
            this.textBox1.Text += b6.Text;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Button b1 = (Button)sender;
            this.textBox1.Text += b1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button b2 = (Button)sender;
            this.textBox1.Text += b2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button b3 = (Button)sender;
            this.textBox1.Text += b3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b4 = (Button)sender;
            this.textBox1.Text += b4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button b5 = (Button)sender;
            this.textBox1.Text += b5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button b7 = (Button)sender;
            this.textBox1.Text += b7.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button b8 = (Button)sender;
            this.textBox1.Text += b8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button b9 = (Button)sender;
            this.textBox1.Text += b9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button b0 = (Button)sender;
            this.textBox1.Text += b0.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (this.lastCommand == "+")
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = this.result.ToString();
                this.result = 0;
            }
            else if (this.lastCommand == "-")
            {
                this.result -= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = this.result.ToString();
                this.result = 0;

            }
            else if (this.lastCommand == "*")
            {
                this.result *= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = this.result.ToString();
                this.result = 0;

            }
            else if (this.lastCommand == "/")
            {
                this.result /= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = this.result.ToString();
                this.result = 0;

            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Button b_plus = (Button)sender;
            this.result += Convert.ToDouble(this.textBox1.Text);
            this.lastCommand = "+";
            this.textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b_minus = (Button)sender;
            this.result += Convert.ToDouble(this.textBox1.Text);
            this.lastCommand = "-";
            this.textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button b_mult = (Button)sender;
            this.result += Convert.ToDouble(this.textBox1.Text);
            this.lastCommand = "*";
            this.textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b_divide = (Button)sender;
            this.result += Convert.ToDouble(this.textBox1.Text);
            this.lastCommand = "/";
            this.textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b_C = (Button)sender;
            this.result = 0;
            this.textBox1.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button b_X = (Button)sender;
            this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1); // nie dziala
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button b_coma = (Button)sender;
            this.textBox1.Text += b_coma.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!this.textBox1.Text.Contains("-")) {
                this.textBox1.Text = this.textBox1.Text.Insert(0, "-");
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text.Remove(0, 1);
            }
        }
    }
}