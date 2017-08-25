using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalcularMY
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operate1 = string.Empty;
        string operate2 = string.Empty;
        double value = 0;
        double num1, num2;
        string operation = " "; //string for operation
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void botton_zero_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            //input += "1";
            Button b = (Button)sender;

            result.Text += b.Text;
        }

        private void button_one_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                 result.Clear();
            operation_pressed = false;
            //input += "1";
            Button b = (Button)sender;

            result.Text += b.Text;

        }
        private void button_two_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            //input += "2";
            Button b = (Button)sender;

            result.Text += b.Text;
        }
        private void button_three_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            //input += "3";
            Button b = (Button)sender;

            result.Text += b.Text;
        }
        private void button_four_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            //input += "4";
            Button b = (Button)sender;

            result.Text += b.Text;
        }

        private void button_five_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            //input += "5";

            operation_pressed = false;
            Button b = (Button)sender;

            result.Text += b.Text;
        }

        private void button_six_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
           // input += "6";
            Button b = (Button)sender;

            result.Text += b.Text;
        }

        private void button_seven_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            //input += "7";
            operation_pressed = false;
            Button b = (Button)sender;

            result.Text += b.Text;
        }

        private void button_eight_Click(object sender, EventArgs e)
        {

            if ((result.Text == "0") || (operation_pressed))
                result.Clear();

            operation_pressed = false; 
            // input += "8";
            Button b = (Button)sender;

            result.Text += b.Text;
        }

        private void button_nine_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            //input += "9";
            Button b = (Button)sender;

            result.Text += b.Text;
        }
        private void dot_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") || (operation_pressed))
                result.Clear();
            operation_pressed = false;
            // input += ".";
            Button b = (Button)sender;

            result.Text += b.Text;
        }



        // private void botton_Click(object sender, EventArgs e)
        //{
        //if ((result.Text == "0") || (operation_pressed))
        // result.Clear();
        //                Button b = (Button)sender;

        // result.Text += b.Text;

        // }
        

        

        private void CE_Click(object sender, EventArgs e)   //buttom CE
        {
            result.Text = "0";    //if click it show 0
        }
       
            private void Operater_click(object sender, EventArgs e)
            {
                Button b = (Button)sender;
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
            }

            private void total_click(object sender, EventArgs e)  //+ - * %
            {
                switch (operation)
                {
                    case "+":
                        result.Text = (value + double.Parse(result.Text)).ToString();
                        break;
                    case "-":
                        result.Text = (value - double.Parse(result.Text)).ToString();
                        break;
                    case "*":
                        result.Text = (value * double.Parse(result.Text)).ToString();
                        break;
                    case "/":
                        result.Text = (value / double.Parse(result.Text)).ToString();
                        break;


                    default:
                        break;

                }
            operation_pressed = false;
        }

       

        /* private void Operater_click(object sender, EventArgs e)
{
    Button b = (Button)sender;
    operation = b.Text;
    value = Double.Parse(result.Text);
    operation_pressed = true;
}

private void total_click(object sender, EventArgs e)  //+ - * %
{
    switch (operation)
    {
        case "+":
            result.Text = (value + double.Parse(result.Text)).ToString();
            break;
        case "-":
            result.Text = (value - double.Parse(result.Text)).ToString();
            break;
        case "*":
            result.Text = (value * double.Parse(result.Text)).ToString();
            break;
        case "/":
            result.Text = (value / double.Parse(result.Text)).ToString();
            break;


        default:
            break;

    }
    operation_pressed = false;
}*/


        private void percent_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text) / 100 * value).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text) / 100 * value).ToString();
                    break;

            }

        }
    }
}
    

