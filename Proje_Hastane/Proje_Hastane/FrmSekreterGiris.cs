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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlBağlantısı bgl = new sqlBağlantısı();

        
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2", bgl.baglantı());
            komut.Parameters.AddWithValue("@p1",mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SekreterDetay frm = new SekreterDetay();
                frm.tc = mskTc.Text;
                
                frm.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Hatalı Tc ya da şifre girdiniz..");
            }
            bgl.baglantı().Close();
            

        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
