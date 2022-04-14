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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*1. Na vstupu je dán řetězec. Button1 - z tohoto řetězce vypusťte všechna velká písmena
          bez diakritiky (pomocí cyklu). Button2 – z řetězce smažte všechny hvězdičky (bez
         cyklu).*/
            string retezec = textBox1.Text;
            string upraveni="";
            foreach(char c in retezec)
            {
                if(c<Convert.ToChar(64) ||c> Convert.ToChar(91))
                {
                    upraveni=upraveni+ Convert.ToString(c);
                }
            }
            textBox2.Text = upraveni;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            string konecna = retezec;
           konecna=konecna.Replace("*", "");
            textBox2.Text = konecna;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Na vstupu je dán řetězec.\nButton1 - z tohoto řetězce vypusťte všechna velká písmena bez diakritiky(pomocí cyklu).\nButton2 – z řetězce smažte všechny hvězdičky(bez cyklu). ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
