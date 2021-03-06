using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değiskenler_Sinema_BüfeProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int m1, s1, c1, b1;
            int toplam;

            m1 = Convert.ToInt32(txtMisir.Text);
            s1 = Convert.ToInt32(txtSu.Text);
            c1 = Convert.ToInt32(txtCay.Text);
            b1 = Convert.ToInt32(txtBilet.Text);

            m1 = m1 * 4;
            s1 = s1 * 2;
            c1 = c1 * 3;
            b1 = b1 * 20;
            toplam = m1 + s1 + c1 + b1;
            kasatutar = kasatutar + toplam;
            lblToplam.Text = toplam.ToString();
            lblKasa.Text = kasatutar.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = " ";
            txtSu.Text = " ";
            txtCay.Text = " ";
            txtMisir.Text = " ";
            txtMisir.Focus();

        }
    }
}
