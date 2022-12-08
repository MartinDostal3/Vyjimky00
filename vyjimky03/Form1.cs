using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vyjimky03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int soucet = 0;

            try
            {
                for (int i = 0; i < n; i++)
                {
                    int cislo = 0;
                    try
                    {
                        cislo = int.Parse(textBox2.Lines[i].ToString());
                    }
                    catch (OverflowException)
                    {
                        MessageBox.Show("V souboru je na řádku příliš velké nebo malé číslo.");
                        continue; // cyklus nepokracuje a probehne od zacatku 
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("V souboru je zapsán jiný znak než číslo.");
                        continue;
                    }
                    soucet = checked(soucet + cislo);

                }
                MessageBox.Show("Soucet je: " + soucet);

            }
            catch (OverflowException)
            {
                MessageBox.Show("Součet je příliš velké nebo malé číslo");
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Počet požadovaných řádků pro součet je větší než počet řádků");
            }



        }
    }
}
