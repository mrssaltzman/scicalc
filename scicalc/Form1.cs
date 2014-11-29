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
        
        private double ilkSayi;
        private char islem;
        private String memory;
        private bool islemBitti = false;
        private String satir1 = "";
        private String satir2 = "0";

        private Font satir1Font = new Font("Arial", 10);
        private Font satir2Font = new Font("Arial", 16);

        private void renderDisplay()
        {
            this.rdisplay.Text = "";
            this.rdisplay.SelectionFont = satir1Font;
            this.rdisplay.AppendText(satir1 + "\r\n");
            this.rdisplay.SelectionFont = satir2Font;
            this.rdisplay.AppendText(satir2);
            this.rdisplay.SelectAll();
            this.rdisplay.SelectionAlignment = HorizontalAlignment.Right;
        }

        public Form1()
        {
            InitializeComponent();
            renderDisplay();
        }

        private void updateNumber(String c)
        {
            if (islemBitti)
            {
                satir2 = "";
                islemBitti = false;
            }
            if (satir2 == "0") {
                satir2 = "";
            }
            satir2 += c;
            renderDisplay();
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
            satir2 = "0";
            renderDisplay();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(satir2);
            satir1 = satir2 + " +";
            satir2 = "";
            islem = '+';
            renderDisplay();
            
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(satir2);
            satir1 = satir2 + " -";
            satir2 = "";
            islem = '-';
            renderDisplay();
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(satir2);
            satir1 = satir2 + " *";
            satir2 = "";
            islem = '*';
            renderDisplay();
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            ilkSayi = double.Parse(satir2);
            satir1 = satir2 + " /";
            satir2 = "";
            islem = '/';
            renderDisplay();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            double ikinciSayi = double.Parse(satir2);
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
            renderDisplay();
            islemBitti = true;
        }

        private void button_negate_Click(object sender, EventArgs e)
        {
            double sayi = double.Parse(satir2);
            sayi = sayi * -1;
            satir2 = sayi.ToString();
            renderDisplay();
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (!satir2.Contains(","))
            {
                satir2 = satir2 + ",";
                renderDisplay();
            }
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            int length = satir2.Length - 1;
            if (length > 0)
            {
                satir2 = satir2.Substring(0, length);
            }
            else
            {
                satir2 = "0";
            }
            renderDisplay();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ilkSayi = 0;
            islem = '\0';
            satir1 = "";
            satir2 = "0";
            renderDisplay();
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            satir1 = "sqrt(" + satir2 + ")";
            satir2 = Math.Sqrt(double.Parse(satir2)).ToString();
            renderDisplay();
        }

        private void button_resiproc_Click(object sender, EventArgs e)
        {
            satir1 = "reciproc(" + satir2 + ")";
            satir2 = (1 / double.Parse(satir2)).ToString();
            renderDisplay();
        }

        private void button_ms_Click(object sender, EventArgs e)
        {
            memory = satir2;
            label_memory.Visible = true;
        }

        private void button_mr_Click(object sender, EventArgs e)
        {
            satir2 = memory;
            renderDisplay();
        }

        private void button_mc_Click(object sender, EventArgs e)
        {
            memory = "0";
            label_memory.Visible = false;
        }

        private void button_mplus_Click(object sender, EventArgs e)
        {
            memory = (double.Parse(memory) + double.Parse(satir2)).ToString();
        }

        private void button_mminus_Click(object sender, EventArgs e)
        {
            memory = (double.Parse(memory) - double.Parse(satir2)).ToString();
        }

        private void button_sqr_Click(object sender, EventArgs e)
        {
            double ikinciSayi = double.Parse(satir2);
            satir1 = "sqr(" + satir2 +")";
            satir2 = (ikinciSayi*ikinciSayi).ToString();
            renderDisplay();
        }

        private void button1_cube_Click(object sender, EventArgs e)
        {
            double ikinciSayi = double.Parse(satir2);
            satir1 = "cube(" + satir2 + ")";
            satir2 = (ikinciSayi * ikinciSayi * ikinciSayi).ToString();
            renderDisplay();
        }
    }
}
