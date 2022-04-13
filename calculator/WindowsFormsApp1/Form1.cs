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
        double result1, result2, sum, Mul, min, Div, darsad;
        Boolean opmul, opsum, opmin, opdiv,opdrsad;

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                result1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opmul = true;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                result1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opdiv = true;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                result1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opmin = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                result1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opsum = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                result1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                opdrsad = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }
                   

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
             if (textBox1.Text != "")
            {
                result2 = double.Parse(textBox1.Text);
                if(opsum==true)
                {
                    sum = result1 + result2;
                    textBox1.Text = sum.ToString();
                    opsum = false;
                }
               else if (opmin == true)
                {
                    min = result1 - result2;
                    textBox1.Text = sum.ToString();
                    opmin = false;
                }

                else if (opmul == true)
                {
                    Mul = (result1 * result2);
                    textBox1.Text = sum.ToString();
                    opmul = false;
                }
                else if (opdiv == true)
                {
                    Div = result1 / result2;
                    textBox1.Text = sum.ToString();
                    opdiv = false;
                }
                else if (opdiv == true)
                {
                    darsad = result1 % result2;
                    textBox1.Text = sum.ToString();
                    opdrsad = false;
                }
            }
        }
    }
}
