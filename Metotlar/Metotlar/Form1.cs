using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //void varsa geriye değer döndürmeyendir...
        private void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = ""; 
            textBox5.Text = "";
            textBox1.Focus();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void renklendirme()
        {
            textBox1.BackColor = Color.Red;
            textBox2.BackColor = Color.GreenYellow;
            textBox3.BackColor = Color.Green;
            textBox4.BackColor = Color.Purple;
            textBox5.BackColor = Color.Aqua;
            textBox1.Text = "Mert";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            renklendirme();
        }
    }
}
