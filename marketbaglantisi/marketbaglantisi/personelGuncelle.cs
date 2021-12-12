using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace marketbaglantisi
{
    public partial class personelGuncelle : Form
    {
        public personelGuncelle()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=market;user ID=postgres;password=utku");

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut4 = new NpgsqlCommand("update personel_kayit set telefon_no=@p1 , personel_adi=@p2 , personel_soyadi=@p3, maas=@p4 , eposta=@p5 ,sifre =@p6 where telefon_no=@p7", baglanti);
            komut4.Parameters.AddWithValue("@p7", textBox1.Text);
            komut4.Parameters.AddWithValue("@p1", textBox7.Text);
            komut4.Parameters.AddWithValue("@p2", textBox2.Text);
            komut4.Parameters.AddWithValue("@p3", textBox3.Text);
            komut4.Parameters.AddWithValue("@p4", int.Parse(textBox4.Text));
            komut4.Parameters.AddWithValue("@p5", textBox5.Text);
            komut4.Parameters.AddWithValue("@p6", textBox6.Text);
            komut4.ExecuteNonQuery();
            MessageBox.Show("personel bir şekilde güncellendi");
            baglanti.Close();
        }
    }
}
