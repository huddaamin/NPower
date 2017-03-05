using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops
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
            int loopStart= 11;
            int loopEnd =1;

            loopStart = int.Parse(textBox1.Text);
            loopEnd = int.Parse(textBox2.Text);
            int multiplyby = int.Parse(textBox3.Text);

            listBox1.Items.Clear();
            for (int i = loopStart; i < loopEnd; i++)

                answer = multiplyby * i;
            listBox1.Items.Add(loopStart + "times" + multiplyby + "=" + answer.ToString()); 
             
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
