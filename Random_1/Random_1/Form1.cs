using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayı,sayı2,sayı3,sayı4;
            //sayı = rnd.Next(1, 10);//ilk değer dahil ikinci değer dahil değil..
            //sayı2 = rnd.Next(10, 50);
            //sayı3 = rnd.Next(50, 100);
            //label1.Text = sayı.ToString();
            //label2.Text = sayı2.ToString();
            //label3.Text = sayı3.ToString();
            sayı = rnd.Next(1, 5);
            sayı2 = rnd.Next(1, 5);
            sayı3 = rnd.Next(1, 5);
            sayı4 = rnd.Next(1, 5);
            label1.Text = sayı.ToString();
            label2.Text = sayı2.ToString();
            label3.Text = sayı3.ToString();
            label4.Text = sayı4.ToString();

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);

            if (sayı==a)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (sayı2 == b)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (sayı3 == c)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (sayı4 == d)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }
    }
}
