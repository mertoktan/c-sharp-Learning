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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-B0AFPCV;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        
        void temizle()
        {
            txtPersonelid.Text = "";
            txtPersonelad.Text = "";
            txtPersonelSoyad.Text = "";
            cmbSehir.Text = "";
            maskedTxtMaas.Text = "";
            txtMeslek.Text = "";
            radioButtonB.Checked=false;
            radioButtonE.Checked =false;
            txtPersonelad.Focus();

        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
           this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (Perad,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p6,@p5)", baglantı);
            komut.Parameters.AddWithValue("@p1", txtPersonelad.Text);
            komut.Parameters.AddWithValue("@p2", txtPersonelSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", maskedTxtMaas.Text );
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Eklendi");
        }
       
        private void radioButtonE_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonE.Checked == true) { 
                label8.Text = "true";
            }


        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonB.Checked == true)
            {
                label8.Text = "false";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;           //önemli

            txtPersonelid.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            txtPersonelad.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            txtPersonelSoyad.Text= dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            cmbSehir.Text= dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            maskedTxtMaas.Text= dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            label8.Text= dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            txtMeslek.Text= dataGridView1.Rows[seçilen].Cells[6].Value.ToString();


        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButtonE.Checked = true;

            }
            if (label8.Text == "False")
            {
                radioButtonB.Checked = true;

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_Personel Where Perid=@k1", baglantı);
            komutsil.Parameters.AddWithValue("@k1", txtPersonelid.Text);
            komutsil.ExecuteNonQuery();

            baglantı.Close();
            MessageBox.Show("Kayıt silindi ");

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komutgun = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7", baglantı);
            komutgun.Parameters.AddWithValue("@a1", txtPersonelad.Text);
            komutgun.Parameters.AddWithValue("@a2", txtPersonelSoyad.Text);
            komutgun.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutgun.Parameters.AddWithValue("@a4", maskedTxtMaas.Text);
            komutgun.Parameters.AddWithValue("@a5", label8.Text);
            komutgun.Parameters.AddWithValue("@a6", txtMeslek.Text);
            komutgun.Parameters.AddWithValue("@a7", txtPersonelid.Text);

            komutgun.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Personel Bilgi Güncellendi");

        }

        private void btnİstatis_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr = new Frmİstatistik();
            fr.Show();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafik gr = new FrmGrafik();
            gr.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            FrmRaporlar frm = new FrmRaporlar();
            frm.Show();

        }
    }
}
