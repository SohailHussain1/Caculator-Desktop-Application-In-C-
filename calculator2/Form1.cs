using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int a = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           // int b = int.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                label4.Text = (a + b).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Please Enter the  valid Values","Eroor",MessageBoxButtons.OKCancel);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                label4.Text = (a - b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the  valid Values", "Eroor", MessageBoxButtons.OKCancel);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                label4.Text = (a * b).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the valid Values", "Eroor", MessageBoxButtons.OKCancel);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                label4.Text = (a / b).ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Please Enter the valid Values", "Eroor", MessageBoxButtons.OKCancel);
            }
       
   
        }
    }
}
