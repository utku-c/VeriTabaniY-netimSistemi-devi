﻿using Npgsql;
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
    public partial class personelEkle : Form
    {
        public personelEkle()
        {
            InitializeComponent();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            personelAra personel = new personelAra();
            personel.ShowDialog();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            personelGoruntule prsn = new personelGoruntule();
            prsn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelGuncelle pg = new personelGuncelle();
            pg.ShowDialog();

        }
    }
}
