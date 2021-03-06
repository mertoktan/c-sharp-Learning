using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] kisiler =
            //{
            //    "Mert","Ahmet,","Ayşe","Filiz","Furkan","Yılkan","Bertuğ"
            //};
            //foreach(string k in kisiler)
            //{
            //    listBox1.Items.Add(k);
            //}
            int toplam = 0;
            int sayac = 0;
            int[] tamsay = { 2, 73, 40, 20, 44, 78, 31, 54 };
            foreach(int t in tamsay)
            {
                listBox1.Items.Add(t);
                if (t%4==0)
                {
                    toplam = toplam + t;
                    sayac++;
                }
                label1.Text = sayac.ToString();
                label2.Text = toplam.ToString();
            }
            
            
            //foreach(int s in sınavlar)
            //{
            //    listBox1.Items.Add(s);
            //    toplam = toplam + s;
            //}
            //int ort;
            //ort = toplam / sınavlar.Length;
            //label1.Text = toplam.ToString();
            //label2.Text = ort.ToString();


        }
    }
}
