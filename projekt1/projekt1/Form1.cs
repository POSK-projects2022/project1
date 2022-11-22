using System.Windows.Forms;

namespace projekt1
{
    public partial class Form1 : Form
    {
        int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 80;

        //center
        int cx, cy;

        Bitmap bmp;
        Graphics g;
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
            if (this.textBox1.Text.Length > 0) {
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
            } else
            {
                MessageBox.Show("Wprowadź liczbę!");
            }
            
        }
        private void button12_Click(object sender, EventArgs e)
        {
            Button b_plus = (Button)sender;
            if (this.lastCommand == "+")
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "+";
            }
            else if (this.lastCommand == "-")
            {
                this.result -= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "+";

            }
            else if (this.lastCommand == "*")
            {
                this.result *= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "+";

            }
            else if (this.lastCommand == "/")
            {
                this.result /= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "+";

            } else
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.lastCommand = "+";
                this.textBox1.Text = "";

            }
                
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b_minus = (Button)sender;
            if (this.lastCommand == "+")
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "-";
            }
            else if (this.lastCommand == "-")
            {
                this.result -= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "-";

            }
            else if (this.lastCommand == "*")
            {
                this.result *= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "-";

            }
            else if (this.lastCommand == "/")
            {
                this.result /= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "-";

            } else
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.lastCommand = "-";
                this.textBox1.Text = "";
            }
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button b_mult = (Button)sender;
            if (this.lastCommand == "+")
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "*";
            }
            else if (this.lastCommand == "-")
            {
                this.result -= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "*";


            }
            else if (this.lastCommand == "*")
            {
                this.result *= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "*";


            }
            else if (this.lastCommand == "/")
            {
                this.result /= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "*";


            }
            else
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.lastCommand = "*";
                this.textBox1.Text = "";
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b_divide = (Button)sender;
            if (this.lastCommand == "+")
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "/";

            }
            else if (this.lastCommand == "-")
            {
                this.result -= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "/";


            }
            else if (this.lastCommand == "*")
            {
                this.result *= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "/";


            }
            else if (this.lastCommand == "/")
            {
                this.result /= Convert.ToDouble(this.textBox1.Text);
                this.textBox1.Text = "";
                this.lastCommand = "/";


            }
            else
            {
                this.result += Convert.ToDouble(this.textBox1.Text);
                this.lastCommand = "/";
                this.textBox1.Text = "";
            }
            
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
            this.textBox1.Text = this.textBox1.Text.Remove(this.textBox1.Text.Length - 1, 1); 
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

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void skórka1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            if (menuItem.Checked) { 
                this.BackgroundImage = Image.FromFile("C:/Users/User/Source/Repos/project1/projekt1/projekt1/Resources/pexels-eberhard-grossgasteiger-1287142.jpg");
                this.skórka2ToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.skórka3ToolStripMenuItem.CheckState = CheckState.Unchecked;

            }




        }

        private void skórka2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            if (menuItem.Checked) { 
                this.BackgroundImage = Image.FromFile("C:/Users/User/Desktop/projectsPOSK/skorka2.jpg");
                this.skórka1ToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.skórka3ToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
        }

        private void skórka3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            if (menuItem.Checked) { 
                this.BackgroundImage = Image.FromFile("C:/Users/User/Desktop/projectsPOSK/skorka3.png");
                this.skórka2ToolStripMenuItem.CheckState = CheckState.Unchecked;
                this.skórka1ToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.cyfrowyToolStripMenuItem.Checked) {
                this.pictureBox1.Visible = false;
                this.label1.Visible = true;
                this.label1.Text = DateTime.Now.ToString("hh:mm:ss");
            } else if(this.analogowyToolStripMenuItem.Checked) {
                this.pictureBox1.Visible = true;
                this.label1.Visible = false;
                g = Graphics.FromImage(bmp);

                //get time
                int ss = DateTime.Now.Second;
                int mm = DateTime.Now.Minute;
                int hh = DateTime.Now.Hour;

                int[] handCoord = new int[2];

                //clear
                g.Clear(Color.White);

                //draw circle
                g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

                //draw figure
                g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
                g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
                g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
                g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

                //second hand
                handCoord = msCoord(ss, secHAND);
                g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //minute hand
                handCoord = msCoord(mm, minHAND);
                g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //hour hand
                handCoord = hrCoord(hh % 12, mm, hrHAND);
                g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //load bmp in picturebox1
                pictureBox1.Image = bmp;

                //disp time
                this.Text = "Analog Clock -  " + hh + ":" + mm + ":" + ss;

                //dispose
                g.Dispose();
            }
            

            

        }

        //coord for minute and second hand
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //coord for hour hand
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       


     

    
        
        private void cyfrowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            if (this.analogowyToolStripMenuItem.Checked)
            {
                this.analogowyToolStripMenuItem.CheckState = CheckState.Unchecked;
                menuItem.CheckState = CheckState.Checked;
            } else
            {
                menuItem.CheckState = CheckState.Checked;
            }
        }

        private void analogowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
            if (this.cyfrowyToolStripMenuItem.Checked)
            {
                this.cyfrowyToolStripMenuItem.CheckState= CheckState.Unchecked;
                menuItem.CheckState = CheckState.Checked;
            } else
            {
                menuItem.CheckState = CheckState.Checked;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //backcolor
            this.BackColor = Color.White;

            //timer
            timer1.Interval = 1000;      //in millisecond
            timer1.Tick += new EventHandler(this.timer1_Tick);
            timer1.Start();
        }
    }
}