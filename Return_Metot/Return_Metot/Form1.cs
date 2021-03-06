using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Return_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int toplam(int s1,int s2)
        {
            int topla = s1 + s2;
            
            return topla;

        }
        int çıkar (int s1,int s2)
        {
            int çık = s1 - s2;
            return çık;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            
            textBox3.Text = toplam(a, b).ToString();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            textBox4.Text = çıkar(a, b).ToString();
        }
    }
}
