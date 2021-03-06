﻿using System;
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
    public partial class FrmGrafik : Form
    {
        public FrmGrafik()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-B0AFPCV;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void FrmGrafik_Load(object sender, EventArgs e)
        {
            //şehirlerde kaç kişi olduğu
            baglantı.Open();
            SqlCommand komut1 = new SqlCommand("Select PerSehir,count(*) from Tbl_Personel Group By PerSehir ", baglantı);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }

            baglantı.Close();

            //şehirlerin ortalama Maaş

            baglantı.Open();
            SqlCommand komut2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) from Tbl_Personel Group By PerMeslek", baglantı);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }

            baglantı.Close();


        }
    }
}
