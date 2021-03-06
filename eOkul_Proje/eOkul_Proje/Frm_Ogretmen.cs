using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOkul_Proje
{
    public partial class Frm_Ogretmen : Form
    {
        public Frm_Ogretmen()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmKulüp klb = new FrmKulüp();
            klb.Show();
        }

        private void btnders_Click(object sender, EventArgs e)
        {
            FrmDersler fr = new FrmDersler();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr = new FrmOgrenci();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmSınavNot fra = new FrmSınavNot();
            fra.Show();
        }
    }
}
