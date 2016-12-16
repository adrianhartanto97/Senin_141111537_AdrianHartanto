﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Latihan_POS
{
    public partial class frmDeleteCustomer : Form
    {
        static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=latihan_pos;Uid=root;password=;");
        public frmDeleteCustomer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDeleteCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void buka_koneksi()
        {
            if (koneksi.State != ConnectionState.Open)
                koneksi.Open();
        }

        private void tutup_koneksi()
        {
            if (koneksi.State != ConnectionState.Closed)
                koneksi.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string delete = "DELETE FROM customer WHERE ID = @id";
            try
            {
                int res;
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd;

                buka_koneksi();
                cmd = new MySqlCommand(delete, koneksi);
                cmd.Parameters.AddWithValue("@id", txtId.Text);

                da.DeleteCommand = cmd;

                DialogResult rslt;
                rslt = MessageBox.Show("Apakah Anda yakin ?", "Yakin?", MessageBoxButtons.YesNo);

                if (rslt == DialogResult.Yes)
                {
                    res = da.DeleteCommand.ExecuteNonQuery();
                    txtId.Text = "";
                    MessageBox.Show("Informasi Customer berhasil dihapus", "Deleted");
                }
                tutup_koneksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
