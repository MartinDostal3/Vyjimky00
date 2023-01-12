using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Vyjimky07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"..\..\osoby.txt"))
                {
                    int pocet = 0;
                    int soucet = 0;
                    double prumer = 0;
                    while (!reader.EndOfStream)
                    {
                        try
                        {
                            
                            string line = reader.ReadLine();
                            DateTime dnes = DateTime.Today;
                            DateTime narozen = DateTime.Parse(line);

                            int age = dnes.Year - narozen.Year;
                            DateTime bDayThisYear = narozen.AddYears(age);

                            if (bDayThisYear > dnes) age--;
                            soucet += age;
                            ++pocet;
                            MessageBox.Show(age + " let");
                        }
                        catch (FormatException)
                        {
                            
                            continue;
                        }



                    }
                    prumer = (double)soucet / pocet;
                    MessageBox.Show("prumerny vek je: " + prumer);


                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("soubor nebyl nalezen");
            }
            catch (IOException)
            {
                MessageBox.Show("chyba při čtení souboru.(soubor může být poškozený)");
            }
          
            
        }
    }
}
