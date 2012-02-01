using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calc : Form
    {
        //initilizing some variables
        float a, b, c, z;
        float f = 0;
        char math_pros;

        //initilizing component
        public Calc()
        {
            InitializeComponent();
        }
        
        //public methods
        public int Add(int aVal1, int aVal2)
        {
            return aVal1 + aVal2;
        }        
        public int Mul(int mVal1, int mVal2)
        {
            return mVal1 * mVal2;
        }        
        public int Div(int dVal1, int dVal2)
        {
            return dVal1 / dVal2;
        }
        public int Sub(int sVal1, int sVal2)
        {
            return sVal1 - sVal2;
        }

        //Empty method
        public string EmptyMethod()
        {
            return null;
        }
        
        //add button click event
        private void add_Click(object sender, EventArgs e)
        {
            //let the equals operation know that the add button had been clicked
            math_pros = 'a';

            float.TryParse(tb.Text, out z);
            a = z + f;
            f = a;

            tb.Clear();
            tb.Focus();
        }

        //subtract button click event
        private void subtract_Click(object sender, EventArgs e)
        {
            math_pros = 's';

            float.TryParse(tb.Text, out a);

            tb.Clear();
            tb.Focus();

        }

        //multiply button click event
        private void multiply_Click(object sender, EventArgs e)
        {
            math_pros = 'm';

            float.TryParse(tb.Text, out a);

            tb.Clear();
            tb.Focus();
        }

        //divide button click event
        private void divide_Click(object sender, EventArgs e)
        {
            math_pros = 'd';

            float.TryParse(tb.Text, out a);

            tb.Clear();
            tb.Focus();
        }

        //equals button click event
        private void equals_Click(object sender, EventArgs e)
        {
            float.TryParse(tb.Text, out b);
                if (math_pros == 'm')
                {
                   c = a * b;
                }
                if (math_pros == 'd')
                {
                    c = a / b;
                }
                if (math_pros == 's')
                {
                    c = a - b;
                }
                if (math_pros == 'a')
                {
                    c = a + b;
                }

                tb.Clear();
                lblAns.Text = Convert.ToString("Your Answer Is: " + c);
        }

        //code to clear the text box and reset the label
        private void clear_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;

            tb.Clear();
            tb.Focus();
            lblAns.Text = "Your Answer Is: ";
            
        }

        //code for the number buttons
        private void button1_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "2";     
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            tb.Text = tb.Text + "0.";
        }
        
    }
}
