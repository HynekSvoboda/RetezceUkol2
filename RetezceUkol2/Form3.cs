using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetezceUkol2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char [] vstup=textBox1.Text.ToCharArray();
            int hodnota =Convert.ToInt32( numericUpDown1.Value);
            string zaheslovani = "";
            char znak='A';
            foreach (char c in vstup)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    if (c + hodnota > 90)
                    {
                        znak = Convert.ToChar((c - 26) + hodnota);
                        zaheslovani = zaheslovani + Convert.ToString(znak);
                    }
                    else
                    {
                        znak = Convert.ToChar(c + hodnota);
                        zaheslovani = zaheslovani + Convert.ToString(znak);
                    }
                }
                else
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        if (c + hodnota > 122)
                        {
                            znak = Convert.ToChar((c - 26) + hodnota);
                            zaheslovani = zaheslovani + Convert.ToString(znak);
                        }
                        else
                        {
                            znak = Convert.ToChar(c + hodnota);
                            zaheslovani = zaheslovani + Convert.ToString(znak);
                        }
                    }
                    else zaheslovani = zaheslovani+Convert.ToString(c);
                }
            }
            textBox2.Text = zaheslovani;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2. Vytvořte projekt na šifrování vstupního textu pomocí Cézarovy šifry.\nŠifrování textu spočívá v posouvání znaku v abecedě o určitý, pevně stanovený počet znaků.\nNapříklad slovo \"ahoj\"; se s posunem textu o 1 přeloží jako \"bipk\".\nPosun umožníme uživateli vybrat.\nPosun se bude provádět v rozsahu písmen anglické abecedy.\nBudou se šifrovat velká a malá písmena anglické abecedy.\nOstatní znaky budou beze změny.\nPísmeno z při posunu o 1 přejde do písmene a.\nUmožněte text odšifrovat.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
