using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string kontrol = "Ali";
            if (kontrol == textBox1.Text) { label1.Text = "Hoşgeldiniz"; }
            else
                label1.Text = "hatalı giriş.";
                MessageBox.Show("Yanlış kişiyi girdiniz..");*/

            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (a == 5)
            {
                label1.Text = "Doğru sayı girdiniz";
            }
            else
                label1.Text = "Hatalı sayı";
        }
    }
}
