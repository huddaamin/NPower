﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool buttonClicked = false;
            if (buttonClicked == true)
            {
                MessageBox.Show("buttonClicked has a value of true");
            }
            else
            {
                MessageBox.Show("buttonClicked has a value of false");
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
        }
        

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }
    }
}
