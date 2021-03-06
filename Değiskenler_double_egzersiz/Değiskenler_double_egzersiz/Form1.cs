using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değiskenler_double_egzersiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = textBox1.Text;soyad = textBox2.Text;

            int s1, s2, s3;
            double ort;
            s1 = Convert.ToInt32(textBox3.Text);
            s2 = Convert.ToInt32(textBox4.Text);
            s3 = Convert.ToInt32(textBox5.Text);

            ort = (s1 + s2 + s3) / 3;

            textBox1.Text = ad;
            textBox2.Text = soyad;

            listBox1.Items.Add("Ad : " + ad + "Soyad : " + soyad + "Ortalama : " + ort);


        }
    }
}
