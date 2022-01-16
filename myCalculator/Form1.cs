using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCalculator
{
    public partial class Form1 : Form
    {
        public float firstNum = 0;
        public float secondNum = 0;
        public string calcType = "";
        public float result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(firstNum == 0)
            {
                firstNum = 1;
            }
            else
            {
                secondNum = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 2;
            }
            else
            {
                secondNum = 2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 3;
            }
            else
            {
                secondNum = 3;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 4;
            }
            else
            {
                secondNum = 4;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 5;
            }
            else
            {
                secondNum = 5;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 6;
            }
            else
            {
                secondNum = 6;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 7;
            }
            else
            {
                secondNum = 7;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 8;
            }
            else
            {
                secondNum = 8;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 9;
            }
            else
            {
                secondNum = 9;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (firstNum == 0)
            {
                firstNum = 0;
            }
            else
            {
                secondNum = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            calcType = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calcType = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calcType = "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calcType = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (calcType)
            {
                case "/":
                    result = firstNum / secondNum;
                    endResult.Text = result.ToString();
                    break;
                case "*":
                    result = firstNum * secondNum;
                    endResult.Text = result.ToString();
                    break;
                case "+":
                    result = firstNum + secondNum;
                    endResult.Text = result.ToString();
                    break;
                case "-":
                    result = firstNum - secondNum;
                    endResult.Text = result.ToString();
                    break;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            calcType = "";
        }
    }
}
