﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eOkul_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frm_Ogrencınot fr = new frm_Ogrencınot();
            fr.numara = textBox1.Text;
            fr.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Ogretmen fr = new Frm_Ogretmen();
            fr.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
