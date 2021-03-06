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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string tcno;

        sqlBağlantısı bgl = new sqlBağlantısı();
        
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tcno;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTel.Text = dr[4].ToString();
                txtSifre1.Text = dr[5].ToString();
                comboCinsiyet.Text = dr[6].ToString();

             }
            bgl.baglantı().Close();
            

            
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglantı());//where tcsini seçtiğimizi değiştirdik..
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTel.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre1.Text);
            komut.Parameters.AddWithValue("@p5", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@p6", mskTC.Text);
            komut.ExecuteNonQuery();//INSERT UPDATE DELETE İŞLEMLERİNDE KULLANILIR UNUTMA....

            bgl.baglantı().Close();

            MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


        }
    }
}
