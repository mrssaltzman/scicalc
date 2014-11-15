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
        private String number = "";
        private double ilkSayi;
        private char islem;
        private bool islemBitti = false;
        private String satir1 = "";
        private String satir2 = "";

        private void updateDisplay()
        {
            this.display.Text = satir1 + "\r\n" + satir2;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void clearNumber()
        {
            number = "";
        }

        private void updateNumber(String c)
        {
            if (islemBitti)
            {
                number = "";
                satir2 = "";
                islemBitti = false;
            }
            number += c;
            satir2 += c;
            updateDisplay();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            updateNumber("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            updateNumber("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            updateNumber("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            updateNumber("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            updateNumber("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            updateNumber("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            updateNumber("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            updateNumber("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            updateNumber("9");
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            updateNumber("0");
        }

        private void button_clearentry_Click(object sender, EventArgs e)
        {
            satir2 = "";
            updateDisplay();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(number);
            satir1 = satir2 + " +";
            satir2 = "";
            clearNumber();
            islem = '+';
            updateDisplay();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(number);
            satir1 = satir2 + " -";
            satir2 = "";
            clearNumber();
            islem = '-';
            updateDisplay();
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(number);
            satir1 = satir2 + " *";
            satir2 = "";
            clearNumber();
            islem = '*';
            updateDisplay();
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(number);
            satir1 = satir2 + " /";
            satir2 = "";
            clearNumber();
            islem = '/';
            updateDisplay();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            double ikinciSayi = double.Parse(number);
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
            else
            {
                sonuc = ikinciSayi;
            }
            satir2 = sonuc.ToString();
            satir1 = "";
            updateDisplay();
            number = sonuc.ToString();
            islemBitti = true;
        }

        private void button_negate_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(this.display.Text);
            sayi = sayi * -1;
            this.display.Text = sayi.ToString();
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            satir2 = satir2 + ",";
            updateDisplay();
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            int length = this.display.Text.Length - 1;
            this.display.Text = this.display.Text.Substring(0, length);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ilkSayi = 0;
            islem = '\0';
            clearNumber();
            satir1 = "";
            satir2 = "";
            updateDisplay();
        }

           
    }
}
