using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int sayi = 20;int sayi2 = 21;
            int toplam = sayi + sayi2;
            label1.Text = toplam.ToString();*/
            int kenar, alan, çevre;
            kenar = 5;
            alan = kenar * kenar;
            çevre = 4 * kenar;
            label1.Text = kenar.ToString() + " " + alan.ToString() + " " + çevre.ToString();
        }
    }
}
