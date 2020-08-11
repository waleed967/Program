using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorInterface
{
    public partial class Form1 : Form
    {
        double _firstNumber;
        string _operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        { if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "1";
            }
        else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "1";
            }
            
        }

        private void btn_2_Click(object sender, EventArgs e)
        { if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)

            { txt_FirstNumber.Text = "2"; }
            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "2";
            }

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "3";
            }

            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "4";
            }

            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "5";
            }

            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "6";
            }

            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "7";
            }

            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "8";
            }

            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "9";
            }

            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "9";
            }

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txt_FirstNumber.Text == "0" && txt_FirstNumber.Text != null)
            {
                txt_FirstNumber.Text = "0";
            }

            else
            {
                txt_FirstNumber.Text = txt_FirstNumber.Text + "0";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            _firstNumber = Convert.ToDouble(txt_FirstNumber.Text);
            _operation = "+";
            txt_FirstNumber.Text = "0";
            
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            double _secondNumber;
            double Result;

            _secondNumber = Convert.ToDouble(txt_FirstNumber.Text);

            if (_operation == "+")
            {
                Result = (_firstNumber + _secondNumber);
                txt_FirstNumber.Text = Convert.ToString(Result);
                _firstNumber = Result;
                
            }

            if (_operation == "-")
            {
                Result = (_firstNumber - _secondNumber);
                txt_FirstNumber.Text = Convert.ToString(Result);
                _firstNumber = Result;
            }
            if (_operation == "*")
            {
                Result = (_firstNumber * _secondNumber);
                txt_FirstNumber.Text = Convert.ToString(Result);
                _firstNumber = Result;
            }

            if (_operation == "/")
            {
                Result = (_firstNumber / _secondNumber);
                txt_FirstNumber.Text = Convert.ToString(Result);
                _firstNumber = Result;
            }

        }

        private void btn_Sub_Click(object sender, EventArgs e)
        {
            _firstNumber = Convert.ToDouble(txt_FirstNumber.Text);
            _operation = "-";
            txt_FirstNumber.Text = "0";
        }

        private void btn_Mul_Click(object sender, EventArgs e)
        {
            _firstNumber = Convert.ToDouble(txt_FirstNumber.Text);
            _operation = "*";
            txt_FirstNumber.Text = "0";
            
        }

        private void btn_Div_Click(object sender, EventArgs e)
        {

            _firstNumber = Convert.ToDouble(txt_FirstNumber.Text);
            _operation = "/";
            txt_FirstNumber.Text = "0";
            
        }
    }
}
