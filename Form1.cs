using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float a, b;
        int count;
        bool sign = true;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 0;
        }
        
        private void OneButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 1;
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 2;
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 3;
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 4;
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 5;
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 6;
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 7;
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 8;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + 9;
        }

        private void calculate()
        {
            switch (count)
                {
                    case 1:
                        
                        b = a + float.Parse(textBox_Res.Text);
                        textBox_Res.Text = b.ToString();
                        break;
                    case 2:
                        b = a - float.Parse(textBox_Res.Text);
                        textBox_Res.Text = b.ToString();
                        break;
                    case 3:
                        b = a * float.Parse(textBox_Res.Text);
                        textBox_Res.Text = b.ToString();
                        break;
                    case 4:
                        if (float.Parse(textBox_Res.Text) == 0)
                        {
                            double c = Double.NaN;
                            textBox_Res.Text = c.ToString();
                            break;
                        }
                        b = a / float.Parse(textBox_Res.Text);
                        textBox_Res.Text = b.ToString();
                        break;
                        
                    default:
                        break;
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox_Res.Text);
            textBox_Res.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            sign = true;

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox_Res.Text); 
            textBox_Res.Clear(); 
            count = 2; 
            label1.Text = a.ToString() + "-"; 
            sign = true;
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox_Res.Text);
            textBox_Res.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            sign = true;
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox_Res.Text);
            textBox_Res.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            sign = true;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = "";
            label1.Text = "";
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if(sign==true)
            {
                textBox_Res.Text = "-" + textBox_Res.Text;
                sign = false;
            }
            else if (sign==false)
            {
                textBox_Res.Text=textBox_Res.Text.Replace("-", "");
                sign = true;
            }
            
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox_Res.Text.Length - 1;
            string text = textBox_Res.Text;
            textBox_Res.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox_Res.Text = textBox_Res.Text + text[i];
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            textBox_Res.Text = textBox_Res.Text + ",";
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

    }
}