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
    public partial class frm_Ogrencınot : Form
    {
        public frm_Ogrencınot()
        {
            InitializeComponent();
        }
        
        SqlConnection baglantı = new SqlConnection(@"Data Source=DESKTOP-B0AFPCV;Initial Catalog=eOkul;Integrated Security=True");
        public string numara;
        private void frm_Ogrencınot_Load(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("SELECT DERSAD,SINAV1,SINAV2,SINAV3,PROJE , ORTALAMA,DURUM FROM Tbl_Notlar INNER JOIN Tbl_Dersler ON Tbl_Notlar.DERSID = Tbl_Dersler.DERSEID WHERE OGRID = @p1", baglantı);
            komut.Parameters.AddWithValue("p1",numara);
            //this.Text = numara.ToString();

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglantı.Close();


            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("SELECT OGRAD,OGRSOYAD FROM Tbl_Ogrenciler WHERE OGRID=@p2",baglantı);
            komut2.Parameters.AddWithValue("@p2",numara);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                this.Text = dr[0] + " " + dr[1];
            }
            baglantı.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
