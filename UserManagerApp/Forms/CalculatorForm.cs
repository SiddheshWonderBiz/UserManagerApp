using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagerApp.Models;

namespace UserManagerApp.Forms
{
    public partial class CalculatorForm : Form
    {
        string input = "";
        string operand1 = "";
        string operand2 = "";
        char operation;
        bool isOperationPressed = false;
        private bool isResultShown = false;
        private User _currentuser;
        public CalculatorForm(User user)
        {
            InitializeComponent();
            _currentuser = user;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button10_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isResultShown && !isOperationPressed)
            {
                textBox1.Clear();
                isResultShown = false;
                operand1 = "";
                operand2 = "";
            }

            if (!isOperationPressed)
            {
                operand1 += btn.Text;
                textBox1.Text = operand1;
            }
            else
            {
                operand2 += btn.Text;
                textBox1.Text = operand1 + " " + operation + " " + operand2;
            }

        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operand1))
            {
                Button btn = (Button)sender;
                operation = btn.Text[0];
                isOperationPressed = true;
                textBox1.Text = operand1 + " " + operation;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operand1) || string.IsNullOrEmpty(operand2))
            {
                return;
            }

            double num1 = Convert.ToDouble(operand1);
            double num2 = Convert.ToDouble(operand2);
            double res = 0;
            switch (operation)
            {
                case '+':
                    res = num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        res = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    break;

            }
            textBox1.Text = res.ToString();
            operand1 = res.ToString();
            operand2 = "";
            isResultShown = true;
            isOperationPressed = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            input = "";
            operand1 = "";
            operand2 = "";
            operation = '\0';
            isOperationPressed = false;
            textBox1.Text = "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard(_currentuser);
            dashboard.Show();
        }
    }
}
