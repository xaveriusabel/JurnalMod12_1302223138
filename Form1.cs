using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JurnalMod12_1302223138
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            label1.Text = Convert.ToString(CariNilaiPangkat(a,b));
        }

        public static int CariNilaiPangkat(int a, int b)
        {
            if (b < 0)
            {
                return -1;
            }else if ( b == 0){
                return 1;
            }else if (b >= 10 && a >= 100)
            {
                return -2;
            }else
            {
                try
                {
                    checked
                    {
                        int pangkat = 1;
                        for (int i = 0; i < b; i++)
                        {
                            pangkat *= a;
                        }
                        return pangkat;
                    }
                }
                catch(Exception ex)
                {
                    return -3;
                }
            }
            return 0;
        }

       
    }
}
