using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketbaglantisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            urunEkle urun = new urunEkle();
            urun.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            musteriEkle musteri = new musteriEkle();
            musteri.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelEkle personel = new personelEkle();
            personel.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            urunSatis urunsatis = new urunSatis();
            urunsatis.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tedarikci tedarik = new tedarikci();
            tedarik.ShowDialog();
        }
    }
}
