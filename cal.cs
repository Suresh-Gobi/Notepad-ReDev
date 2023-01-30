using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Calculator : Form
    {
        private float num1;
        private int count;
        private float ans;

        public Calculator()
        {
            InitializeComponent();
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            output.Text = output.Text + 7;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(output.Text);
            output.Clear();
            output.Focus();
            int count = 2;
        }

        private void substractionBtn_Click(object sender, EventArgs e)
        {
            if (output.Text != "")
            {
                num1 = float.Parse(output.Text);
                output.Clear();
                output.Focus();
                int count = 1;
            }
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(output.Text);
                    output.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(output.Text);
                    output.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(output.Text);
                    output.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(output.Text);
                    output.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}