using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Proje_Uygulama
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DbE_UrunEntities db = new DbE_UrunEntities();

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString();
            label3.Text = db.Tbl_Urun.Count().ToString();
            label5.Text = db.Tbl_Musterı.Count(x => x.DURUM == true).ToString();
            label7.Text = db.Tbl_Musterı.Count(x => x.DURUM == false).ToString();
            label13.Text = db.Tbl_Urun.Sum(x => x.STOK).ToString();
            label21.Text = db.Tbl_Satıs.Sum(x => x.FIYAT).ToString()+" TL";
            label11.Text = (from x in db.Tbl_Urun orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            label9.Text = (from x in db.Tbl_Urun orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            label15.Text = db.Tbl_Urun.Count(x => x.KATEGORI == 1).ToString();
            label17.Text = db.Tbl_Urun.Count(X => X.URUNAD == "BUZDOLABI").ToString();
            label23.Text = (from x in db.Tbl_Musterı select x.SEHIR).Distinct().Count().ToString();//discint tekrarsız
            label19.Text = db.MARKAGETIR().FirstOrDefault();




        }
    }
}
