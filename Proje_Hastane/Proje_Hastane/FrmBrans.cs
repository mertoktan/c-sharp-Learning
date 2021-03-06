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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlBağlantısı bgl = new sqlBağlantısı();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * From Tbl_Branslar ",bgl.baglantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;

            txtbransid.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            txtbranş.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_Branslar (BransAd) values (@b1)", bgl.baglantı());
            
            komut.Parameters.AddWithValue("@b1", txtbranş.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();

            MessageBox.Show("Yeni bir branş sisteme eklendi..");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE From Tbl_Branslar where Bransid=@b1", bgl.baglantı());
            komut.Parameters.AddWithValue("@b1",txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Branş sistemden silindi...");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Branslar set BransAd=@b1 where Bransid=@b2", bgl.baglantı());
            komut.Parameters.AddWithValue("@b1", txtbranş.Text);
            komut.Parameters.AddWithValue("@b2", txtbransid.Text);
            komut.ExecuteNonQuery();
            bgl.baglantı().Close();
            MessageBox.Show("Seçtiğiniz brans güncellendi...");

        }
    }
}
