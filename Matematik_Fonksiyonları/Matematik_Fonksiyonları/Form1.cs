using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Fonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sayı;
       
        private void button1_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToDouble(textBox1.Text);
            
            label3.Text= Math.Pow(sayı, 2).ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToDouble(textBox1.Text);

            label3.Text = Math.Sqrt(sayı).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToDouble(textBox1.Text);

            label3.Text = Math.Pow(sayı,3).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToDouble(textBox1.Text);

            label3.Text = Math.Abs(sayı).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToDouble(textBox1.Text);

            label3.Text = Math.Floor(sayı).ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToDouble(textBox1.Text);

            label3.Text = Math.Ceiling(sayı).ToString();
        }
    }
}
