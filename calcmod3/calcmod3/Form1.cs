namespace calcmod3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int add = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string number = button1.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string number = button2.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number = button3.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string number = button4.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string number = button5.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string number = button6.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string number = button7.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string number = button8.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string number = button9.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string number = button10.Text;
            textBox1.Text = number;
            textBox1.Show();
        }

        public void button11_Click(object sender, EventArgs e) //Triger add
        {
            //string plus = button11.Text;

            /*if (Convert.ToInt32(textBox1.Text) != 0)
            {
               
                
            }*/

            add = add + Convert.ToInt32(textBox1.Text);
            //textBox1.Text = plus;
            /*textBox1.Text = Convert.ToString(add);
            textBox1.Show();*/
            textBox1.Clear();
        }

        public void button12_Click(object sender, EventArgs e) //Triger sum dari semua penjumlahan
        {
            add = add + Convert.ToInt32(textBox1.Text);
            textBox1.Text = Convert.ToString(add);
            textBox1.Show();
        }
    }
}
