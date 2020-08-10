using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);

            double result = firstNumber + secondNumber;
            txtResult.Text = Convert.ToString(result);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);

            double result = firstNumber - secondNumber;
            txtResult.Text = Convert.ToString(result);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);

            double result = firstNumber * secondNumber;
            txtResult.Text = Convert.ToString(result);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
            double secondNumber = Convert.ToDouble(txtSecondNumber.Text);

            double result = firstNumber / secondNumber;
            txtResult.Text = Convert.ToString(result);
        }
    }
}
