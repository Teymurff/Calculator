using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        double resValue = 0;
        string operPerform = "";
        bool isOperisPerform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            if ((tbx_res.Text == "0")||(isOperisPerform))
                tbx_res.Clear();
            isOperisPerform = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!tbx_res.Text.Contains("."))
                    tbx_res.Text = tbx_res.Text + button.Text;

            }
            else
            tbx_res.Text = tbx_res.Text + button.Text;
        }

        private void oper_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resValue != 0)
            {
                button16.PerformClick();
                operPerform = button.Text;
               isOperisPerform = true;

            }
            else
            {

                operPerform = button.Text;
                resValue = Double.Parse(tbx_res.Text);
                isOperisPerform = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tbx_res.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbx_res.Text = "0";
            resValue = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operPerform)
            {
                case "+":
                    tbx_res.Text = (resValue + Double.Parse(tbx_res.Text)).ToString();
                    break;
                case "-":
                    tbx_res.Text = (resValue - Double.Parse(tbx_res.Text)).ToString();
                    break;
                case "*":
                    tbx_res.Text = (resValue * Double.Parse(tbx_res.Text)).ToString();
                    break;
                case "/":
                    tbx_res.Text = (resValue / Double.Parse(tbx_res.Text)).ToString();
                    break;
                default:
                    break;
            }
            resValue = Double.Parse(tbx_res.Text);
            
        }
    }
}
