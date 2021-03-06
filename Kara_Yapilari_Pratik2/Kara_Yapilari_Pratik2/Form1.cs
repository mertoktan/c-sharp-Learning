using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kara_Yapilari_Pratik2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double adet,top;
            
            
            adet = Convert.ToDouble(textBox1.Text);
            if (0 <= adet && adet<=20)
            {
                top = adet * 8;
                top = top-(top * 0.2);
                label3.Text = top.ToString();
            }
            else if(21 <= adet && adet <= 40)
            {
                top = adet * 8;
                top = top - (top * 0.4);
                label3.Text = top.ToString();
            }
            else
                top = adet * 8;
                top = top - (top * 0.5);
                label3.Text = top.ToString();

        }
    }
}
