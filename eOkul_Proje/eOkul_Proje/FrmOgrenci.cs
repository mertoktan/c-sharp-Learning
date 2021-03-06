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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-B0AFPCV;Initial Catalog=eOkul;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
            SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-B0AFPCV;Initial Catalog=eOkul;Integrated Security=True");
            baglantı.Open();


            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kulupler",baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbKulup.DisplayMember = "KULUPAD";
            cmbKulup.ValueMember = "KULUPID";
            cmbKulup.DataSource = dt;
            baglantı.Close();



        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

           
            ds.OgrEkle(txtogrAd.Text, txtogrSoyad.Text, byte.Parse(cmbKulup.SelectedValue.ToString()),c);

            MessageBox.Show("Öğrenci Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.oGRsİL(int.Parse(textİd.Text));
            ds.OgrenciListesi();
            MessageBox.Show("Öğrenci silindi");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textİd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtogrAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtogrSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbKulup.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }
        string c = "";
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            
            ds.OGRGUNCELLE(txtogrAd.Text,txtogrSoyad.Text, byte.Parse(cmbKulup.SelectedValue.ToString()) , c, int.Parse(textİd.Text));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                c = "Kız";
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButton2.Checked == true)
            {
                c = "Erkek";
            }

            MessageBox.Show("Güncelleme yapıldı..");
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=ds.Ogrgetir(txtara.Text);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
