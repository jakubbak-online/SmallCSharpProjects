using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.GUI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string total;
        string option;
        long number1, number2;
        double result;
        bool hasCompleted;

        private void NotANumber()
        {
            textDisplay.Clear();
            textDisplay.Text = "NaN";
            hasCompleted = true;
        }

        private void FullClear()
        {
            textDisplay.Clear();
            hasCompleted = false;
            number1 = 0;
            number2 = 0;
            result = 0;
        }

        private void FullClearAfterCalculations()
        {
            if (hasCompleted)
            {
                FullClear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            option = "*";
            number1 = long.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            option = "-";
            number1 = long.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button16.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button15.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button14.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button12.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button8.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            option = "+";
            number1 = long.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            option = "/";
            number1 = long.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FullClearAfterCalculations();

            textDisplay.Text = textDisplay.Text + button5.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
        }

        private void textDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                number2 = long.Parse(textDisplay.Text);
            }catch (System.FormatException){
                Console.WriteLine(number1);
                NotANumber();
                return;
            }

            switch (option)
            {
                case "+":
                    result = (double)number1 + (double)number2;
                    break;
                case "/":
                    result = (double)number1 / (double)number2;
                    break;
                case "-":
                    result = (double)number1 - (double)number2;
                    break;
                case "*":
                    result = (double)number1 * (double)number2;
                    break;
                default:
                    result = number1;
                    break;
            }

            textDisplay.Clear();
            textDisplay.Text = result.ToString();
            hasCompleted = true;
        }
    }
}
