using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Proje_Uygulama
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        DbE_UrunEntities db = new DbE_UrunEntities();
        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Tbl_Admin where x.KULLANICI == textBox1.Text && x.SİFRE == textBox2.Text select x;
            if (sorgu.Any())
            {
                FrmAnaForm fr = new FrmAnaForm();
                this.Hide();
                fr.Show();

            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız...");
            }
        }
    }
}
