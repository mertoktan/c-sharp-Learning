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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        DbE_UrunEntities db = new DbE_UrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.Tbl_Kategori.AD,
                                            x.DURUM
                                        }).ToList();




        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.URUNAD = txtad.Text;
            t.MARKA = txtmarka.Text;
            t.STOK = short.Parse(txtstok.Text);
            t.KATEGORI = int.Parse(cmbkat.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtfiyat.Text);
            //t.DURUM = bool.Parse(txtdurum.Text);
            t.DURUM = true;
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün sisteme kaydedildi.");





        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün silindi");



        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            urun.URUNAD = txtad.Text;
            urun.MARKA = txtmarka.Text;
            urun.STOK = short.Parse(txtstok.Text);

            db.SaveChanges();
            MessageBox.Show("Ürün güncelle");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori 
                               select new { x.ID, x.AD }).ToList();

            cmbkat.ValueMember = "ID";
            cmbkat.DisplayMember = "AD";
            cmbkat.DataSource = kategoriler;


        }
    }
}
