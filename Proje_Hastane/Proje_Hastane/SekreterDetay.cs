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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlBağlantısı bgl = new sqlBağlantısı();
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;

            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglantı());//where if demek
            komut.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                lblAdsoyad.Text = dr[0].ToString();
            }
            bgl.baglantı().Close();


            //Branşları DataGride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar ",bgl.baglantı());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorların Bütün Değerlerini DataGride Aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select Doktorid,(DoktorAd +' '+ DoktorSoyad) as 'Doktorlar ',DoktorBrans From Tbl_Doktorlar ", bgl.baglantı());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı Comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglantı().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("INSERT INTO Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglantı());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglantı().Close();

            MessageBox.Show("Randevu Oluşturuldu...");

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1 ", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + "" + dr[1]);
            }

            bgl.baglantı().Close();



        }

        private void btnOluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Duyurular (Duyuru) values (@d1)", bgl.baglantı());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Duyuru Oluşturuldu..");

        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli dr = new FrmDoktorPaneli();
            dr.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans fr = new FrmBrans();
            fr.Show();

        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi rdv = new FrmRandevuListesi();
            rdv.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
        }
    }
}
