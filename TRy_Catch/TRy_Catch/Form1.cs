﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRy_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayı1 = Convert.ToInt32(textBox1.Text);
                int sayı2 = Convert.ToInt32(textBox2.Text);
                int toplam = sayı1 + sayı2;
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Değerlerinizi kontrol edin..");
            }
        }
    }
}
