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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbE_UrunEntities db = new DbE_UrunEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.Tbl_Kategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Kategori t = new Tbl_Kategori();
            t.AD = textBox2.Text;
            db.Tbl_Kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var kt = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(kt);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            var kt = db.Tbl_Kategori.Find(x);//find metodu buluyor
            kt.AD = textBox2.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme yapıldı");



        }
    }
}
