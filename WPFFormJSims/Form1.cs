﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFFormJSims
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_myOtherClick;

        }

        private void Button1_myOtherClick(object sender, EventArgs e)
        {
            myOtherLabel.Text = "Hello again!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myLabel.Text = "Hello World";
        }
    }
}
