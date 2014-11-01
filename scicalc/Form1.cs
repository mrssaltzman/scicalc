using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace scicalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            this.display.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            this.display.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            this.display.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            this.display.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            this.display.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            this.display.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            this.display.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            this.display.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            this.display.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            this.display.Text += "0";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.display.Text = "";
        }

       

        
    }
}
