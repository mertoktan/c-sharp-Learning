﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Değiskenler_double1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* double sayı;
             sayı=5.2;
             label1.Text = sayı.ToString();*/
            /*double s1, s2, s3, ort;
            s1 = 60;
            s2 = 55;
            s3 = 88;
            ort = (s1 + s2 + s3) / 3;
            label1.Text = ort.ToString("0.00");//format ayarlayabiliyorsun..Noktadan sonra kaç sıfır varsa o kadar sayı alır
            */

            double sayı;
            sayı = Convert.ToDouble(textBox1.Text);
            label1.Text = sayı.ToString("0.00");


        }
    }
}
