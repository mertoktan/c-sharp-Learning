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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-B0AFPCV;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {

            //toplam personel sayısı....
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) From Tbl_Personel", baglantı);
            SqlDataReader dr1 = komut1.ExecuteReader();//Select için sorguyu çalıştırıyor.
            
            while (dr1.Read()) {
                lblTopPer.Text = dr1[0].ToString();
            }
            baglantı.Close();

            //Evli Personel Sayısı..

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) From Tbl_Personel where PerDurum=1", baglantı);
            SqlDataReader dr2 = komut2.ExecuteReader();//Select için sorguyu çalıştırıyor.
            while (dr2.Read())
            {
                lblevli.Text = dr2[0].ToString();
            }
            baglantı.Close();

            //Bekar Personel Sayısı
            baglantı.Open();

            SqlCommand komut3 = new SqlCommand("select count(*) From Tbl_Personel where PerDurum=0", baglantı);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblbekar.Text = dr3[0].ToString();
            }
            baglantı.Close();

            //şehir sayısı
            baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) From Tbl_Personel", baglantı);//Kaç adet şehir olduğunu saydı...önemli!!
            SqlDataReader dr4 = komut4.ExecuteReader();//count komutu kaç adet olduğunu sayar...
            while (dr4.Read())
            {
                lblsehir.Text = dr4[0].ToString();
            }

            baglantı.Close();

            //Toplam Maaş
            baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select Sum(PerMaas) From Tbl_Personel", baglantı);//sum komutu topladı
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbltopmaas.Text = dr5[0].ToString();
            }
            baglantı.Close();


            //Ortalama Maaş

            baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select Avg(PerMaas) From Tbl_Personel", baglantı);//Avg ortalamasını alır...
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblortmaas.Text = dr6[0].ToString();
            }



            baglantı.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
