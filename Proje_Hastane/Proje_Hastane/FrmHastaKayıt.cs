using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proje_Hastane
{
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }

        sqlBağlantısı bgl = new sqlBağlantısı();

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4", mskTel.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre1.Text);
            komut.Parameters.AddWithValue("@p6", comboCinsiyet.Text);
            komut.ExecuteNonQuery();

            bgl.baglantı().Close();

            MessageBox.Show("Hasta kayıt edildi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void FrmHastaKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
