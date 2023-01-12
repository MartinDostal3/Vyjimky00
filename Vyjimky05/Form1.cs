using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Vyjimky05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            int[] pole = new int[textBox1.Lines.Length];
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                try
                {
                    int cislo = int.Parse(textBox1.Lines[i]);
                    try
                    {
                        int dvojnasobek = checked(cislo * 2);
                        pole[i] = dvojnasobek;
                    }
                    catch (OverflowException)
                    {
                        
                        pole[i] = cislo;
                    }
                }
                catch (FormatException)
                {
                    pole[i] = 0;
                }
                catch (OverflowException)
                {
                    string text = textBox1.Lines[i];
                    if (text[0] == '-')
                    {
                        pole[i] = Int32.MinValue;
                    }
                    else
                    {
                        pole[i] = Int32.MaxValue;
                    }
                }
            }
            listBox1.Items.Clear();
            foreach (int x in pole)
            {
                listBox1.Items.Add(x);
            }
        }
    }
}
