﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1213452
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double fi = double.Parse((textBox1.Text));
            double se = double.Parse((textBox3.Text));
            double Result = (fi / se);
            label4.Text = Result.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fi = double.Parse((textBox1.Text));
            double se = double.Parse((textBox3.Text));
            double Result = se + fi;
            label4.Text = Result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fi = double.Parse((textBox1.Text));
            double se = double.Parse((textBox3.Text));
            double Result = fi - se;
            label4.Text = Result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double fi = double.Parse((textBox1.Text));
            double se = double.Parse((textBox3.Text));
            double Result = fi * se;
            label4.Text = Result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
