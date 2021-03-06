using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> llpersonellist()
        {
            return DALPersonel.PersonelListesi();
        }

        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad!="" && p.Soyad!="" && p.Maas>=3500 &&p.Ad.Length>=3 )
            {
                return DALPersonel.PersonelEkle(p);


            }
            else
            {
                return -1;
            }


        }
        public static bool LLPErsonelSil(int per)
        {
            if (per>=1 )
            {
                return DALPersonel.PersonelSıl(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLPersonelGuncelle (EntityPersonel p)
        {
            if (p.Ad.Length>=4 && p.Ad!="" && p.Maas>=4500)
            {
                return DALPersonel.PersonelGunccelle(p);
            }
            else
            {
                return false;


            }
        }

    }
}
