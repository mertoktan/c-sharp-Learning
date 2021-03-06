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
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_DerslerTableAdapter ds = new DataSet1TableAdapters.Tbl_DerslerTableAdapter();
        private void FrmDersler_Load(object sender, EventArgs e)
        {

            //datasource ile kolay bir şekilde veritabınında çektik
            
            dataGridView1.DataSource = ds.DersListesi();








        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtdersAd.Text);
            MessageBox.Show("Ders eklendi");

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(txtdersAd.Text,byte.Parse(textİd.Text));
            MessageBox.Show("Ders Güncellendi");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(textİd.Text));
            MessageBox.Show("Ders Silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textİd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
