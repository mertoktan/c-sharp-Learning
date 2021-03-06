using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String[] kisiler = {
            //    "Ali",
            //    "Ahmet",
            //    "Aslı",
            //    "Mert",
            //    "Demet"
            //};
            //label1.Text = kisiler[3];
            int[] sayılar =
            {
                1,2,3,4,5,6
            };
            label1.Text = sayılar[5].ToString();
        }
    }
}
