using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.llpersonellist();
            dataGridView1.DataSource = PerList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehır = txtsehır.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            ent.Gorev = txtgorev.Text;

            LogicPersonel.LLPersonelEkle(ent);

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPErsonelSil(ent.Id);


        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehır = txtsehır.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            ent.Gorev = txtgorev.Text;
            LogicPersonel.LLPersonelGuncelle(ent);


        }
    }
}
