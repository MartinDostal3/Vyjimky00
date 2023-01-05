using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vyjimky06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vysledek = 1;

            try
            {
                using (StreamReader reader = new StreamReader(@"..\..\cisla.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        int cislo;
                        try
                        {
                            cislo = int.Parse(line);


                            vysledek = checked(vysledek * cislo);
                        }
                        catch (OverflowException)
                        {
                            MessageBox.Show("cislo na radku je prilis velke nebo male");
                        }
                        catch(FormatException)
                        {
                           //cislo neni cele, nezahrnujeme jej do soucinu
                        }
                        

                    }
                    MessageBox.Show("vysledek je: " + vysledek);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("soubor nebyl nalezen");
            }
            catch (IOException)
            {
                MessageBox.Show("chyba při čtení souboru (soubor je poškozený)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
