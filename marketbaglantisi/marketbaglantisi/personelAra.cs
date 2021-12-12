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
    public partial class personelAra : Form
    {
        public personelAra()
        {
            InitializeComponent();
        }

        private void personelAra_Load(object sender, EventArgs e)
        {

        }

        NpgsqlConnection baglanti2 = new NpgsqlConnection("server=localHost;port=5432;Database=market;user ID=postgres;password=utku");

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti2.Open();
            
            string sorgu2;
            
            string t;
            t = textBox1.Text;
            sorgu2 = "select * from bul(\'"+t+"\')";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu2, baglanti2);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglanti2.Close();

        }
    }
}
