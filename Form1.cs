using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            int fiyat;
            double son1, son2;
            ad = Convert.ToString(textBox2.Text);
            fiyat = Convert.ToInt32(textBox1.Text);
            son1 = (fiyat * 8 / 100)+fiyat ;
            son2 = (fiyat * 18 / 100)+fiyat ;
            listBox1.Items.Add("Ürün: "+ ad +"%8 KDV ile: " + son1 + "%18 KDV ile: " + son2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
