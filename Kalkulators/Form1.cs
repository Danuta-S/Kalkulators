using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulators
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operand = "";
        bool enter_value = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text == "0" || enter_value)
            {
                CalculatorDisplay.Text = "";
            }
             
            Button b = (Button)sender;
            CalculatorDisplay.Text += b.Text;
            enter_value = false;
        }

        private void Operators_Click(object sender, EventArgs e)
        {
            enter_value = true;
            Button b = (Button)sender;
            string newOperand = b.Text;

            displayInsideOfDisplay.Text = displayInsideOfDisplay.Text + " " + CalculatorDisplay.Text + " " + newOperand;

            switch (operand)
            {
                case "+":
                    CalculatorDisplay.Text = (result + double.Parse(CalculatorDisplay.Text)).ToString();
                    break;
                case "-":
                    CalculatorDisplay.Text = (result - double.Parse(CalculatorDisplay.Text)).ToString();
                    break;
                case "*":
                    CalculatorDisplay.Text = (result * double.Parse(CalculatorDisplay.Text)).ToString();
                    break;
                case "/":
                    try
                    {
                        CalculatorDisplay.Text = (result / double.Parse(CalculatorDisplay.Text)).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nevar dalit ar nulli");
                    }
                    break;
                default:
                    break;
            }

            result = double.Parse(CalculatorDisplay.Text);
            operand = newOperand;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "0";
            displayInsideOfDisplay.Text = "";
            result = 0;
            operand = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            displayInsideOfDisplay.Text = "";
            enter_value = true;

            switch (operand)
            {
                case "+":
                    CalculatorDisplay.Text = (result + double.Parse(CalculatorDisplay.Text)).ToString();
                    break;
                case "-":
                    CalculatorDisplay.Text = (result - double.Parse(CalculatorDisplay.Text)).ToString();
                    break;
                case "*":
                    CalculatorDisplay.Text = (result * double.Parse(CalculatorDisplay.Text)).ToString();
                    break;
                case "/":
                    try
                    {
                        CalculatorDisplay.Text = (result / double.Parse(CalculatorDisplay.Text)).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nevar dalit ar nulli");
                    }
                    break;
                default:
                    break;
            }

            result = double.Parse(CalculatorDisplay.Text);
            CalculatorDisplay.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ((result * double.Parse(CalculatorDisplay.Text)) / 100).ToString();
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!enter_value && !CalculatorDisplay.Text.Contains(","))
            {
                CalculatorDisplay.Text += ",";
            }
            else if (!CalculatorDisplay.Text.Contains(","))
            {
                CalculatorDisplay.Text = ",";
            }

            enter_value = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!enter_value && !CalculatorDisplay.Text.Contains(","))
            {
                CalculatorDisplay.Text += ",";
            }
            else if (enter_value)
            {
                CalculatorDisplay.Text = "0";
            }

            if (!CalculatorDisplay.Text.Contains(","))
            {
                CalculatorDisplay.Text += ",";
            }

            enter_value = false;
        }

        private void Arrow_Click(object sender, EventArgs e)
        {
            if (CalculatorDisplay.Text.Length > 0)
            {
                CalculatorDisplay.Text = CalculatorDisplay.Text.Remove(CalculatorDisplay.Text.Length - 1, 1);
            }

            if (CalculatorDisplay.Text == "")
            {
                CalculatorDisplay.Text = "0";
            }
            //CalculatorDisplay.Focus();
            //SendKeys.Send("{BACKSPACE}");
        }

        private void PlusMinus_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(CalculatorDisplay.Text);
            CalculatorDisplay.Text = Convert.ToString(-1 * x);
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double squareRoot = double.Parse(CalculatorDisplay.Text);
                displayInsideOfDisplay.Text = System.Convert.ToString("\u221A" + "(" + (CalculatorDisplay.Text) + ")");
                squareRoot = Math.Sqrt(squareRoot);
                CalculatorDisplay.Text = System.Convert.ToString(squareRoot);
            }
            catch
            {
                Console.WriteLine("Nederiga ievade");
            }
        }

        private void Onex_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(CalculatorDisplay.Text));
            CalculatorDisplay.Text = System.Convert.ToString(a);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    Zero.PerformClick();
                    break;
                case "1":
                    One.PerformClick();
                    break;
                case "2":
                    Two.PerformClick();
                    break;
                case "3":
                    Three.PerformClick();
                    break;
                case "4":
                    Four.PerformClick();
                    break;
                case "5":
                    Five.PerformClick();
                    break;
                case "6":
                    Six.PerformClick();
                    break;
                case "7":
                    Seven.PerformClick();
                    break;
                case "8":
                    Eight.PerformClick();
                    break;
                case "9":
                    Nine.PerformClick();
                    break;
                case "%":
                    Mod.PerformClick();
                    break;
                case "+":
                    Plus.PerformClick();
                    break;
                case "-":
                    Minus.PerformClick();
                    break;
                case "*":
                    Multiply.PerformClick();
                    break;
                case "/":
                    Divide.PerformClick();
                    break;
                case ",":
                    DecimalButton.PerformClick();
                    break;
                case "Delete":
                    Arrow.PerformClick();
                    break;
                default:
                    break;
            }
        }

        //    private void button_Click(object sender, EventArgs e)
        //    {
        //        Button b = (Button)sender;

        //        if ((CalculatorDisplay.Text == "0") || (enter_value))
        //        {
        //            CalculatorDisplay.Text = "0";
        //            if ((CalculatorDisplay.Text == "0") && (b.Text == ",")) { }
        //            else
        //            {
        //                CalculatorDisplay.Text = CalculatorDisplay.Text.TrimStart('0');
        //            }
        //            enter_value = false;
        //        }

        //        if (b.Text == ",")
        //        {
        //            if (!CalculatorDisplay.Text.Contains(","))
        //                CalculatorDisplay.Text = CalculatorDisplay.Text + b.Text;
        //        }
        //        else
        //            CalculatorDisplay.Text = CalculatorDisplay.Text + b.Text;
        //    }

        //    private void Operators_Click(object sender, EventArgs e)
        //    {
        //        //enter_value = true;
        //        Button b = (Button)sender;
        //        //operand = b.Text;
        //        //input = double.Parse(CalculatorDisplay.Text);

        //        string newOperand = b.Text;
        //        //displayInsideOfDisplay.Text = displayInsideOfDisplay.Text + " " + CalculatorDisplay.Text + " " + newOperand;
        //        //displayInsideOfDisplay.Text = input + " " + operand;
        //        if (result != 0)
        //        {
        //            Equal.PerformClick();
        //            enter_value = true;
        //            operand = b.Text;
        //            displayInsideOfDisplay.Text = displayInsideOfDisplay.Text + " " + CalculatorDisplay.Text + " " + newOperand;
        //            //displayInsideOfDisplay.Text = result + "   " + operand;
        //        }
        //        else
        //        {
        //            operand = b.Text;
        //            result = double.Parse(CalculatorDisplay.Text);
        //            enter_value = true;
        //            displayInsideOfDisplay.Text = displayInsideOfDisplay.Text + " " + CalculatorDisplay.Text + " " + newOperand;
        //            //displayInsideOfDisplay.Text = result + "   " + operand;
        //        }
        //    }

        //    private void Equal_Click(object sender, EventArgs e)
        //    {
        //        displayInsideOfDisplay.Text = "";
        //        switch (operand)
        //        {
        //            case "+":
        //                CalculatorDisplay.Text = (result + double.Parse(CalculatorDisplay.Text)).ToString();
        //                break;
        //            case "-":
        //                CalculatorDisplay.Text = (result - double.Parse(CalculatorDisplay.Text)).ToString();
        //                break;
        //            case "*":
        //                CalculatorDisplay.Text = (result * double.Parse(CalculatorDisplay.Text)).ToString();
        //                break;
        //            case "/":
        //                CalculatorDisplay.Text = (result / double.Parse(CalculatorDisplay.Text)).ToString();
        //                break;
        //            case "%":
        //                CalculatorDisplay.Text = (result % double.Parse(CalculatorDisplay.Text)).ToString();
        //                break;
        //            default:
        //                break;
        //        }
        //        enter_value = false;
        //        result = double.Parse(CalculatorDisplay.Text);
        //        operand = newOperand;
        //    }

        //private void Equal_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode.Equals(Keys.NumPad5))
        //    {
        //        Five.PerformClick();
        //    }
        //}
    }
}
