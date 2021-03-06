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
namespace eOkul_Proje
{
    public partial class FrmKulüp : Form
    {
        public FrmKulüp()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-B0AFPCV;Initial Catalog=eOkul;Integrated Security=True");
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Kulupler", baglantı);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void FrmKulüp_Load(object sender, EventArgs e)
        {

            listele();

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Kulupler (KULUPAD) VALUES (@P1)", baglantı);
                komut.Parameters.AddWithValue("@P1", txtKulüpAd.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kulüp başarıyla eklendi..");
                
                listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı giriş yaptınız..");
            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textİd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulüpAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("DELETE Tbl_Kulupler WHERE KULUPID=@P1", baglantı);
            komut.Parameters.AddWithValue("@P1",textİd.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kulüp silindi..");
            listele();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Kulupler SET KULUPAD=@P1  WHERE KULUPID=@P2", baglantı);
            komut.Parameters.AddWithValue("@P1", txtKulüpAd.Text);
            komut.Parameters.AddWithValue("@P2", textİd.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kulüp bilgileri başarıyla güncellendi..");
            listele();

        }
    }
}
