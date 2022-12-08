using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, podil, soucin, rozdil, soucet;
            try
            {
                a = int.Parse(textBox1.Text);
                try
                {
                    b = int.Parse(textBox2.Text);
                    podil = a / b;
                    soucet = b + a;
                    soucin = a * b;
                    rozdil = a - b; 
                }
                catch (FormatException)
                {
                    MessageBox.Show("musíš zadat celé číslo");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("nelze dělit nulou");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("musíš zadat celé číslo");
                textBox1.Focus();
                textBox1.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Zadané číslo je příliš velké nebo malé");
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }
    }
}
