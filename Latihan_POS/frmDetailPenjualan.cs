﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Latihan_POS
{
    public partial class frmDetailPenjualan : Form
    {
        DataTable dtPenjualan;
        DataTable dtDetailPenjualan;
        public frmDetailPenjualan()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDetailPenjualan_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            dtPenjualan = new DataTable();
            BindingSource bsPenjualan = new BindingSource();
            bsPenjualan.DataSource = dtPenjualan;
            dgvPenjualan.DataSource = bsPenjualan;

            dtDetailPenjualan = new DataTable();
            BindingSource bsDetailPenjualan = new BindingSource();
            bsDetailPenjualan.DataSource = dtDetailPenjualan;
            dgvDetailPenjualan.DataSource = bsDetailPenjualan;

            lihatDaftarPenjualan();
            lihatDaftarDetailPenjualan();
        }

        private void lihatDaftarPenjualan()
        {
            try
            {
                dtPenjualan.Clear();
                Class.clsDetailPenjualan.SelectAllPenjualan().Fill(dtPenjualan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void lihatDaftarDetailPenjualan()
        {
            try
            {
                dtDetailPenjualan.Clear();
                Class.clsDetailPenjualan.SelectAllDetailPenjualan().Fill(dtDetailPenjualan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lihatDaftarPenjualan();
            lihatDaftarDetailPenjualan();
        }
    }
}
