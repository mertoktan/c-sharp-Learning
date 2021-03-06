using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int doğru = 0, soruno = 0, yanlış = 0;

        private void buttonb_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;

            label8.Text = buttonb.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else { 
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            label8.Text = buttonc.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            label8.Text = buttond.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttona_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            label8.Text = buttona.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void buttonson_Click(object sender, EventArgs e)
        {
            soruno++;
            label4.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiyenin Başkenti Neresidir ?";
                buttona.Text = "İstanbul";
                buttonb.Text = "Ankara";
                buttonc.Text = "Elazığ";
                buttond.Text = "İzmir";
                label7.Text = "Ankara";
                
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Fenerbahçenin kuruluşu ?";
                buttona.Text = "1905";
                buttonb.Text = "1903";
                buttonc.Text = "1907";
                buttond.Text = "1961";
                label7.Text = "1907";


            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Atatürkün Doğum yılı ?";
                buttona.Text = "1881";
                buttonb.Text = "1903";
                buttonc.Text = "1907";
                buttond.Text = "1961";
                label7.Text = "1881";
                buttonson.Text = "Sonuçlar";


            }
            if (soruno == 4) {
                buttona.Enabled = false;
                buttonb.Enabled = false;
                buttonc.Enabled = false;
                buttond.Enabled = false;
                buttonson.Enabled = false;
                MessageBox.Show("Doğru : " + doğru + "Yanlış : " + yanlış);

            }
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            buttona.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
        }
    }
}
