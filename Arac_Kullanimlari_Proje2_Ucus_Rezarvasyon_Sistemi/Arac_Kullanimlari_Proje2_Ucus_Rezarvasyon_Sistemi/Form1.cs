using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari_Proje2_Ucus_Rezarvasyon_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota :"+ comboBox1.Text + "----> " + comboBox2.Text + " Tarih :" + dateTimePicker1.Text + " Saat : " + maskedTextBox1.Text + " " + textBox1.Text+" "+ maskedTextBox2.Text + " " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydedildi...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text = label9.Text;




        }
    }
}
