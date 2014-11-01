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

        private void button_plus_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(this.display.Text);
            this.display.Text = "";
            islem = '+';
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            ilkSayi = int.Parse(this.display.Text);
            this.display.Text = "";
            islem = '-';
        }
        private void button_mult_Click(object sender, EventArgs e)
        {
            ilkSayi = int.Parse(this.display.Text);
            this.display.Text = "";
            islem = '*';

        }
        private void button_div_Click(object sender, EventArgs e)
        {
            ilkSayi = int.Parse(this.display.Text);
            this.display.Text = "";
            islem = '/';
        }

        private double ilkSayi;
        private char islem;

        private void button_equal_Click(object sender, EventArgs e)
        {
            double ikinciSayi = double.Parse(this.display.Text);
            double sonuc = 0;
            if (islem == '+')
            {
               sonuc = ilkSayi + ikinciSayi;  
            }
            else if (islem == '-')
            {
                sonuc = ilkSayi - ikinciSayi;
            }
            else if (islem == '*')
	        {
		       sonuc = ilkSayi * ikinciSayi;
	        }
            else if (islem == '/')
	        {
                sonuc = ilkSayi / ikinciSayi;
	        }
             
            this.display.Text = sonuc.ToString();
        }

        private void button_negate_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(this.display.Text);
            sayi = sayi * -1;
            this.display.Text = sayi.ToString();
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            this.display.Text += ",";

        }

        
        

        
        
    }
}
