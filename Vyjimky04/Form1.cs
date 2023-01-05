using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vyjimky04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a, n;
            double mocnina = 1;
            try
            {
                a = int.Parse(textBox1.Text);
                try
                {
                    n = int.Parse(textBox2.Text);
                    int N = Math.Abs(n);
                    try
                    {
                        for (int i = 0; i < N; i++)
                        {
                            mocnina = checked(mocnina * a);
                        }
                        if (n < 0)
                        {
                            mocnina = checked(1 / mocnina);
                        }
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("Cislo je prilis male, nebo prilis velke");
                    }
                    MessageBox.Show("Mocnina je " + mocnina);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Musis zadat cele cislo");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Cislo je prilis male nebo prilis velke");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Musis zadat cele cislo");
                textBox1.Focus();
                textBox1.SelectAll();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Cislo je prilis male nebo prilis velke");
                textBox1.Focus();
                textBox1.SelectAll();
            }
        }
    }
}
