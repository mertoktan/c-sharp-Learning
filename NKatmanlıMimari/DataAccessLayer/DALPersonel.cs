using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DataAccessLayer
{
    public class DALPersonel
    {

        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Bilgi",Baglantı.bgl);
            if (komut.Connection.State!= ConnectionState.Open)
            {
                komut.Connection.Open();


            }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehır = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);



            }

            dr.Close();
            return degerler;
        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("INSERT INTO Tbl_Bilgi (AD,SOYAD,SEHIR,GOREV,MAAS) VALUES (@P1,@P2,@P3,@P4,@P5)",Baglantı.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();


            }
            komut2.Parameters.AddWithValue("@P1",p.Ad);
            komut2.Parameters.AddWithValue("@P2", p.Soyad);
            komut2.Parameters.AddWithValue("@P3", p.Sehır);
            komut2.Parameters.AddWithValue("@P4", p.Gorev);
            komut2.Parameters.AddWithValue("@P5", p.Maas);

            return komut2.ExecuteNonQuery();




        }

        public static bool PersonelSıl(int p)//id için int
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_Bilgi where ID = @P1",Baglantı.bgl); ;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();


            }
            komut.Parameters.AddWithValue("@P1",p);
            return komut.ExecuteNonQuery()>0;//bool olduğu için büyük işaretini kullandık
            



        }

        public static bool PersonelGunccelle(EntityPersonel ent)
        {
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Bilgi SET AD=@P1,SOYAD=@P2,MAAS=@P3,SEHIR=@P4,GOREV=@P5 WHERE ID=@P6",Baglantı.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();


            }
            komut.Parameters.AddWithValue("@P1",ent.Ad);
            komut.Parameters.AddWithValue("@P2", ent.Soyad);
            komut.Parameters.AddWithValue("@P3", ent.Maas);
            komut.Parameters.AddWithValue("@P4", ent.Sehır);
            komut.Parameters.AddWithValue("@P5", ent.Gorev);
            komut.Parameters.AddWithValue("@P6", ent.Id);
            return komut.ExecuteNonQuery()>0;



        }
    }
}
