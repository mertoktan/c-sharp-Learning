using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değiskenler_int3_4islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı1, sayı2,topla,çarpım,fark,bolum;
            sayı1 = Convert.ToInt32(textBox1.Text);
            sayı2 = Convert.ToInt32(textBox2.Text);
            topla = sayı1 + sayı2;
            çarpım = sayı1 * sayı2;
            fark = sayı1 - sayı2;
            bolum = sayı1 / sayı2;
            MessageBox.Show(topla + "\n " + çarpım + "\n " + fark + "\n " + bolum);

            
        }
    }
}
