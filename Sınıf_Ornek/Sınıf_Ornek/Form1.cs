using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınıf_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba rb = new araba();
            rb.renk = "Mavi";
            rb.hız = 160;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.MARKASI = "Ford";
            rb.YIL = -2015;
            rb.muayene = 2005;
            rb.sahip = "Mert Öktan";
            rb.plaka = "34 VZ 6515";

            label1.Text = rb.renk;
            label2.Text = rb.hız.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI.ToString();
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.sahip;
            label10.Text = rb.plaka;

            pictureBox1.BackColor = Color.Blue;
        }
    }
}
