using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinCalculator
{
    //Class for calator
    public partial class Form1 : Form
    {
        //Declared all common variables
        #region Common Variables

        double firstNum;    //contains first number value
        double secondNum;   //contains second number value
        double result;      //contains result
        string operation = "";
        bool operationPending = false;
        bool point = false;
        int pointClicked = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        //This block defines Backspace, Clear Entry and Clear button
        #region Miscalenius Buttons

        //Backspace button click event
        private void btnBackSpace_Click(object sender, EventArgs e)
        {          

            if(txtResultBox.Text != "0")
            {
                string display = txtResultBox.Text;
                int count = display.Length;
                if (count == 1)
                {
                    txtResultBox.Text = "0";
                }
                else
                {
                    display = display.Remove(count - 1, 1);
                    txtResultBox.Text = display;
                }
            }           
        }

        //Clear Entry button click event
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultBox.Text = "0";
            secondNum = 0;
            pointClicked = 0;
        }

        //Clear button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultBox.Text = "0";
            firstNum = 0;
            secondNum = 0;
            pointClicked = 0;            
        }
        #endregion

        //This block handles all button click events when a number is clicked in the calculator
        #region Digit Click

        //General method to handle button click events of digits
        private void digitClicked(string digit)
        {
            string display = txtResultBox.Text;
            int count = display.Length;
            if (point == false)
            {
                if (operationPending == false)
                {
                    if (display == "0")
                    {
                        txtResultBox.Text = digit;
                    }
                    else
                    {                        
                        txtResultBox.Text = display.Insert(count, digit);
                    }
                }
                else if (operationPending == true)
                {
                    operationPending = false;
                    txtResultBox.Text = digit;
                }

            }
            else
            {
                if (operationPending == false)
                {
                    if (display == "0")
                    {
                        txtResultBox.Text = "0." + digit;
                    }
                    else
                    {
                        txtResultBox.Text = display + "." + digit;
                    }
                }
                else if (operationPending == true)
                {
                    operationPending = false;
                    txtResultBox.Text = "0." + digit;
                }
                point = false;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            digitClicked("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            digitClicked("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            digitClicked("9");            
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            digitClicked("4");            
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            digitClicked("5");            
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            digitClicked("6");            
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            digitClicked("1");            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            digitClicked("2");            
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            digitClicked("3");            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            digitClicked("0");            
        }

        #endregion

        //This block contains method to handle btnEqual Click event
        #region Equal

        //Method to handle btnEqual Click event
        private void btnEqual_Click(object sender, EventArgs e)
        {
            string display = txtResultBox.Text;
            secondNum = Convert.ToDouble(display);

            if (operation == "Divide")
            {
                try
                {
                    result = firstNum / secondNum;
                    display = result.ToString();
                    txtResultBox.Text = display;
                }
                catch (DivideByZeroException ex)
                {
                    txtResultBox.Text = "Cannot divide by zero.";
                }
                catch
                {
                }
            }
            else if (operation == "Multiply")
            {
                result = firstNum * secondNum;
                display = result.ToString();
                txtResultBox.Text = display;
            }
            else if (operation == "Subtract")
            {
                result = firstNum - secondNum;
                display = result.ToString();
                txtResultBox.Text = display;
            }
            else if (operation == "Add")
            {
                result = firstNum + secondNum;
                display = result.ToString();
                txtResultBox.Text = display;
            }

            operation = "Equal";
            operationPending = true;
            pointClicked = 0;
        }

        #endregion

        //This block contains methods for all general operations of a calculator
        #region General Operations

        //This method finds out the number entered and the subsequent operation
        private void GetNumberWithOperationName(string operationName)
        {
            string display = txtResultBox.Text;
            firstNum = Convert.ToDouble(display);
            
            operation = operationName;
            operationPending = true;
            pointClicked = 0;
        }

        //Method for Division Operation
        private void btnDivide_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("Divide");            
        }

        //Method for Multiplication Operation
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("Multiply");
        }

        //Method for Subtraction Operation
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("Subtract");
        }

        //Method for Addition Operation
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("Add");
        }

        //Method for Inversion Operation
        private void btnInverse_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("Inverse");

            result = 1 / firstNum;
            txtResultBox.Text = result.ToString();
        }

        //Method for Square Root Operation
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("SquareRoot");

            result = Math.Sqrt(firstNum);
            txtResultBox.Text = result.ToString();
        }

        //Method for Cube Root Operation
        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("CubeRoot");
            double power = 1.0 / 3.0;
            result = Math.Pow(firstNum,power);
            txtResultBox.Text = result.ToString();
        }

        //Method for Square Operation
        private void btnSquare_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("Square");

            result = firstNum * firstNum;
            txtResultBox.Text = result.ToString();
        }

        //Method for Cube Operation
        private void btnCube_Click(object sender, EventArgs e)
        {
            GetNumberWithOperationName("Cube");

            result = firstNum * firstNum * firstNum;
            txtResultBox.Text = result.ToString();
        }

        #endregion

        //This block contains some special operations like Percentage, Negation, and Decimal Point
        #region Special Operations

        ////Method for Percentage Operation
        private void btnPercentage_Click(object sender, EventArgs e)
        {
            if (operation == "Multiply" || operation == "Divide" || operation == "Subtract" || operation == "Add")
            {
                string display = txtResultBox.Text;
                secondNum = Convert.ToDouble(display);

                result = (firstNum * secondNum) / 100.0;
                txtResultBox.Text = result.ToString();

            }
            else
            {
                txtResultBox.Text = "0";
            }
            operationPending = true;
            pointClicked = 0;
        }

        //Method for putting Decimal Point
        private void btnPoint_Click(object sender, EventArgs e)
        {
            string display = txtResultBox.Text;

            if (pointClicked == 0)
            {
                if (operationPending == true)
                {
                    if (display == "0.")
                    {
                        txtResultBox.Text = "0.";
                    }
                    else
                    {
                        //txtResultBox.Text = display.Insert(count - 1, "7");

                    }
                }
                else if (operationPending == true)
                {
                    operationPending = false;
                    txtResultBox.Text = "0.";
                }
                point = true;
            }
            pointClicked += 1;
        }

        //Method for Negation Operation
        private void btnNegate_Click(object sender, EventArgs e)
        {
            string display = txtResultBox.Text;
            if (display != "0")
            {
                if (display.Substring(0, 1) == "-")
                    display = display.Remove(0, 1);
                else
                    display = display.Insert(0, "-");
                txtResultBox.Text = display;
            }
        }

        #endregion

       
    }
}
