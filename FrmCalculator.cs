using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        private static double num1, num2;
        CalculatorClass cal;

        public FrmCalculator()
        {
            InitializeComponent();
            cbOperator.SelectedIndex = 0;
            cal = new CalculatorClass();

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

  

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);
            switch (cbOperator.Text.ToString())
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.getSum);
                    DisplayTotal.Text = cal.getSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.getSum);
                    break;
                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.getDifference);
                    DisplayTotal.Text = cal.getDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.getDifference);
                    break;
                case "*":
                    cal.CalculateEvent += new Formula<double>(cal.getProduct);
                    DisplayTotal.Text = cal.getProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.getProduct);
                    break;
                case "/":
                    cal.CalculateEvent += new Formula<double>(cal.getQuotient);
                    DisplayTotal.Text = cal.getQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.getQuotient);
                    break;
            }
        }
    }
}