using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
// Isaac Ribero / Jett Conlin / Asgton Sypik
// 12/7/2023
// Simple Calculator
//

namespace c__mrthods_and_event_handlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal Operand1;
            decimal Operand2;
            string Operator = txtOperator.Text;
            decimal Result = 0;
            if (decimal.TryParse(txtOperand1.Text, out Operand1))
            {
                if (decimal.TryParse(txtOperand2.Text, out Operand2))
                {
                    if (Operator == "+" || Operator == "-" || Operator == "*" || Operator == "/")
                    {
                        Result = Calculate(Operand1, Operand2, Operator);
                        txtResult.Text = Result.ToString();
                        txtOperand1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Number");
                    }
                  
                }
                else
                {
                    MessageBox.Show("Invalid Number");
                }
            }
            else
            {
                MessageBox.Show("Invalid Number");
            }
        
        }
        private decimal Calculate(decimal Operand1, decimal Operand2, string Operator)
        {
            decimal Result;

            if (Operator == "+")
            {
                Result = Operand1 + Operand2;
            }
            else if (Operator == "-")
            {
                Result = Operand1 - Operand2;
            }
            else if (Operator == "*")
            {
                Result = Operand1 * Operand2;
            }
            else 
            {
                Result = Operand1 / Operand2;
            }

            return Result;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void ClearResult(object sender, EventArgs e)
        {

        }
    }
}
