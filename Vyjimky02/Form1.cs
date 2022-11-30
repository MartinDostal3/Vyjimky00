using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vyjimky02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int[] pole;

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            Random rnd = new Random();
            pole = new int[n];
            listBox1.Items.Clear();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rnd.Next(1, 21);


            }
            for (int i = 0; i < pole.Length; i++)
            {
                double x = pole[i];
                listBox1.Items.Add(x);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
          

            //pole[0] = 10;
            //pole[5] = 10;

            try
            {
                int mocnina = 1;
                int a = pole[0];
                int n = pole[5];
                for (int i = 0; i < n; i++)
                {
                    checked
                    {
                        mocnina *= a;
                    }
                   
                }
                MessageBox.Show("Mocnina je: " + mocnina);
            }
            catch(OverflowException)
            {
                MessageBox.Show("umocnene cislo je prilis velke nebo male");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("musis zadat cislo 6, nebo vetsi.");
                textBox1.Focus();
                textBox1.SelectAll();

            }


        }
    }
}
