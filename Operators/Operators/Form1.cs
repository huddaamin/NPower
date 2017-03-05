using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;

            firstNumber = int.Parse(textBox1.Text);
            secondNumber = int.Parse(textBox2.Text);

            if (firstNumber != secondNumber)
                
         
            { MessageBox.Show("The first number was greater than the second number");
            }
        }
    }
}
