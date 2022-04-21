using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            txtOutput.Text = Math(txtInput.Text, txtInput2.Text, "addition");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtOutput.Text = Math(txtInput.Text, txtInput2.Text, "subtraction");
        }

        string Math(string str, string str2,string mathtype)
        {
            int input = int.Parse(str);
            int input2 = int.Parse(str2);
            int output = 0;
            if(mathtype == "addition")
            {
                output = input + input2;
            }
            else if(mathtype == "subtraction")
            {
                output = input - input2;
            }

            return output.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
