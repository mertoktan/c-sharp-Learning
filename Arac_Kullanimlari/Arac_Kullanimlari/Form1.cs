using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = " Mert Öktan";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Mert";
            label6.Text = "Öktan";
            label8.Text = "Öğrenci";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "C# öğreniyorum";
            label9.Text = textBox1.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
