using System;
using System.Windows.Forms;

namespace TP_MODUL3_103022400060
{
    public partial class Form1 : Form
    {
        int total = 0;

        public Form1()
        {
            InitializeComponent();
          
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
            button10.Click += button10_Click; 
            button11.Click += button11_Click; 
            button12.Click += button12_Click; 
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text != "..." && label1.Text != "")
            {
                total += int.Parse(label1.Text);
                label1.Text = "";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "...") label1.Text = "";
            label1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text != "..." && label1.Text != "")
            {
                total += int.Parse(label1.Text);
                label1.Text = total.ToString();
                total = 0;
            }
        }
    }
}