using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int çarpım = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= a; i++)
            {
                if ( i!=0 )
                {
                    çarpım = çarpım * i;
                    
                }
                
            }
            listBox1.Items.Add(çarpım);
        }
    }
}
