using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool state = true;
        private string enzanshi;
        private double num1;
        private double num2;
        
        public Form1()
        { 
          InitializeComponent();
          
          
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+"1";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

          
        }


    
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void Plus(object sender, EventArgs e)
        {
            if (state == true)
            {
                state= !state;
                num1 = Convert.ToDouble(textBox1.Text);
                textBox2.Text = textBox1.Text+"+";
                textBox1.Text = null;
                enzanshi = "+";

            }
        }

        private void Minus(object sender, EventArgs e)
        {
            state = !state;
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text+"-";
            textBox1.Text = null;
            enzanshi = "-";

        }

        private void Kakeru(object sender, EventArgs e)
        {
            state = !state;
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text+"×";
            textBox1.Text = null;
            enzanshi = "*";

        }

        private void Waru(object sender, EventArgs e)
        {
            state = !state;
            num1 = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text+"÷";
            textBox1.Text = null;
            enzanshi = "/";

        }

        private void button15_Click(object sender, EventArgs e)
        {
           
            if (state == !state)
            {
                //ここに演算処理を書いてください。
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
