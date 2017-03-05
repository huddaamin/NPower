using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int answer = 0;
            int loopStart;
            int loopEnd;

            loopStart = int.Parse(textBox1.Text);
            loopEnd = int.Parse(textBox2.Text);
            int multiplyBy = int.Parse(textBox3.Text);

            listBox1.Items.Clear();
            
            for (int i = loopStart; i < loopEnd+1; i++)
            {
                answer = multiplyBy*i;
                listBox1.Items.Add(i+"times"+multiplyBy+"=" + answer.ToString());
            }
            MessageBox.Show(answer.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
