﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point konum = new Point();
            Random rnd = new Random();

            konum.X = rnd.Next(0,500);
            konum.Y=rnd.Next(250,750);
            pictureBox1.Location = konum;
        }
    }
}
