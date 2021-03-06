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
    public partial class FrmSınavNot : Form
    {
        public FrmSınavNot()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.Tbl_NotlarTableAdapter ds = new DataSet1TableAdapters.Tbl_NotlarTableAdapter();

        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-B0AFPCV;Initial Catalog=eOkul;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(textİd.Text));
        }

        private void FrmSınavNot_Load(object sender, EventArgs e)
        {
            baglantı.Open();


            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Dersler", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDers.DisplayMember = "DERSAD";
            cmbDers.ValueMember = "DERSEID";
            cmbDers.DataSource = dt;
            baglantı.Close();
        }
        int notid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());    
            textİd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtOrt.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text=dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int sınav1, sınav2, sınav3, proje;
        double ortalama;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            
            //string durum;

            sınav1 = Convert.ToInt32(txtSınav1.Text);
            sınav2 = Convert.ToInt32(txtSınav2.Text);
            sınav3 = Convert.ToInt32(txtSınav3.Text);
            proje = Convert.ToInt32(txtProje.Text);

            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            txtOrt.Text = ortalama.ToString();

            if (ortalama>=50)
            {
                txtDurum.Text = "True";

            }
            if (ortalama<50)
            {
                txtDurum.Text = "False";
            }



        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.Güncelle(byte.Parse(cmbDers.SelectedValue.ToString()),int.Parse(textİd.Text),byte.Parse(txtSınav1.Text), byte.Parse(txtSınav2.Text), byte.Parse(txtSınav3.Text), byte.Parse(txtProje.Text), decimal.Parse(txtOrt.Text), bool.Parse(txtOrt.Text),notid);
        }
    }
}
