using System;
using Npgsql;
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
    public partial class personelGoruntule : Form
    {
        public personelGoruntule()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432;Database=market;user ID=postgres;password=utku");

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();


            string sorgu = "SELECT * FROM personel_kayit";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
