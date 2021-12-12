using Npgsql;
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
    public partial class tedarikci : Form
    {
        public tedarikci()
        {
            InitializeComponent();
        }

        
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=market;user ID=postgres;password=utku");
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM tedarikci";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu,baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into tedarikci (firma_adi,tedarikci_adi,tedarikci_soyadi,telefon) values (@p1,@p2,@p3,@p4)",baglanti);
            komut1.Parameters.AddWithValue("@p1", textBox1.Text); // firma adı
            komut1.Parameters.AddWithValue("@p2", textBox2.Text);
            komut1.Parameters.AddWithValue("@p3", textBox3.Text);
            komut1.Parameters.AddWithValue("@p4", textBox4.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("tedarikçi eklendi");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            

            //MessageBox.Show("tedarikci silindi");

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("SİLME İŞLEMİ YAPIYORSUNUZ !!! TEDARİKCİYİ SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                NpgsqlCommand komut2 = new NpgsqlCommand("DELETE FROM tedarikci where telefon =@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", textBox5.Text);
                komut2.ExecuteNonQuery();
                MessageBox.Show("TEDARİKCİ SİLİNDİ ");

            }

            baglanti.Close();
            

        }

        private void tedarikci_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update tedarikci set firma_adi=@p1 , tedarikci_adi=@p2 , tedarikci_soyadi=@p3, telefon=@p4 where telefon=@p5", baglanti);
            komut3.Parameters.AddWithValue("@p1", textBox9.Text);
            komut3.Parameters.AddWithValue("@p2", textBox8.Text);
            komut3.Parameters.AddWithValue("@p3", textBox7.Text);
            komut3.Parameters.AddWithValue("@p4", textBox6.Text);
            komut3.Parameters.AddWithValue("@p5", textBox10.Text);
            komut3.ExecuteNonQuery();
            MessageBox.Show("tedarikçi başarılı bir şekilde güncellendi");
            baglanti.Close();

        }
    }
}
