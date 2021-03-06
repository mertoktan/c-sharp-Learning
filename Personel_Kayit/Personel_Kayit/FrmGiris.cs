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

namespace Personel_Kayit
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-B0AFPCV;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("Select * From Tbl_Yonetici Where KullaniciAd=@p1 COLLATE SQL_Latin1_General_CP1_CS_AS and Sifre=@p2 COLLATE SQL_Latin1_General_CP1_CS_AS", baglantı);
            komut1.Parameters.AddWithValue("@p1", txtKullAd.Text);
            komut1.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                FrmAnaForm frm = new FrmAnaForm();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifre Yanlış...");
            }

            baglantı.Close();
        }
    }
}
