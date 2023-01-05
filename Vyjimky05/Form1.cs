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
            pole = new int[textBox1.Lines.Count()];
          


            try
            {
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    int cislo = int.Parse(textBox1.Lines[i]);
                    pole[i] = cislo;
                }

            }
            catch(FormatException)
            {
                for (int i = 0; i < pole.Length; i++)
                {
                    pole[i] = 0;
                }
            }
            catch(OverflowException)
            {
                for (int i = 0; i < pole.Length; i++)
                {
                 int cislo = pole[i];
                    if(cislo > Int32.MaxValue)
                    {
                        if (cislo > 0)
                        {
                            cislo = Int32.MaxValue;
                        }
                        else cislo = Int32.MinValue;
                    }
                }
            }
            for (int i = 0; i < pole.Length; i++)
            {
                try
                {
                    pole[i] = checked(pole[i] * 2);
                }
                catch (OverflowException)
                {
                    // přetečení - prvek zůstane nezměněn
                }
            }








            listBox1.Items.Clear();
            foreach (int prvek in pole)
            {
                listBox1.Items.Add(prvek);
            }
        }
    }
}
