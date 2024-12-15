using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesappmakinesi
{
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text=="0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 1;
            label1.Text = label1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 2;
            label1.Text = label1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 3;
            label1.Text = label1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 4;
            label1.Text = label1.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 5;
            label1.Text = label1.Text + 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 6;
            label1.Text = label1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 7;
            label1.Text = label1.Text + 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 8;
            label1.Text = label1.Text + 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 9;
            label1.Text = label1.Text + 9;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + 0;
            label1.Text = label1.Text + 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if(textBox1.Text=="0")
            {
                textBox1.Text = "0";
            }
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
            if (label1.Text == "0")
            {
                label1.Text = "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",")<1)
            { textBox1.Text += ","; }
            label1.Text = label1.Text + ',';
        }
        double sayi1, sayi2, sonuc;
        int secim = 0;
        private void button15_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 2;
            label1.Text = label1.Text + '-';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 3;
            label1.Text = label1.Text + '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 4;
            label1.Text = label1.Text + '/';
        }

        private void button17_Click(object sender, EventArgs e)
        {


            sayi2 = double.Parse(textBox1.Text);
           
            if (secim == 1)
            { sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();
                
               

            }
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();

              


            }
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();

              


            }
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
            
                textBox1.Text = sonuc.ToString();
                



            }

            textBox1.Text = "";
            label1.Text = label1.Text + '=';
           

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "0";

           

        }

      

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 1;
            label1.Text = label1.Text + '+';
        }
    }
}
