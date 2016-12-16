using System;
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
    public partial class frmEditBarang : Form
    {
        static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=latihan_pos;Uid=root;password=;");
        public frmEditBarang()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
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

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            tutup_koneksi();
            this.Close();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            string teks = txtId.Text;
            if (teks.Trim() != "")
            {
                try
                {
                    MySqlCommand cmd = koneksi.CreateCommand();
                    string query = "SELECT * from barang WHERE ID=" + teks;
                    cmd.CommandText = query;
                    buka_koneksi();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    bool ada = false;
                    string kode, nama, jumlahawal, hargahpp, hargajual;
                    kode = nama = jumlahawal = hargahpp = hargajual = "";
                    while (reader.Read())
                    {
                        ada = true;
                        kode = reader.GetString("Kode");
                        nama = reader.GetString("Nama");
                        jumlahawal = reader.GetString("JumlahAwal");
                        hargahpp = reader.GetString("HargaHPP");
                        hargajual = reader.GetString("HargaJual");
                    }
                    tutup_koneksi();
                    if (ada)
                    {
                        txtIdInner.Text = teks;
                        txtKode.Text = kode;
                        txtNama.Text = nama;
                        txtJlhAwal.Text = jumlahawal;
                        txtHrgHPP.Text = hargahpp;
                        txtHargaJual.Text = hargajual;
                        panel1.Visible = true;
                    }
                    else
                    {
                        panel1.Visible = false;
                        MessageBox.Show("ID tidak ditemukan");
                    }
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
        }

        private void frmEditBarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {       
            DateTime skrg = DateTime.Now;
            string update = "UPDATE barang SET Kode = @kode, Nama = @nama, JumlahAwal = @jumlahAwal, HargaHPP = @hargaHPP, ";
            update += "HargaJual = @hargaJual, updated_at = @updatedAt WHERE ID = @id";
            try
            {
                int res;
                MySqlDataAdapter da = new MySqlDataAdapter();
                MySqlCommand cmd;

                cmd = new MySqlCommand(update, koneksi);
                cmd.Parameters.AddWithValue("@id", txtIdInner.Text);
                cmd.Parameters.AddWithValue("@kode", txtKode.Text);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@jumlahAwal", Convert.ToInt32(txtJlhAwal.Text));
                cmd.Parameters.AddWithValue("@hargaHPP", Convert.ToDecimal(txtHrgHPP.Text));
                cmd.Parameters.AddWithValue("@hargaJual", Convert.ToDecimal(txtHargaJual.Text));
                cmd.Parameters.AddWithValue("@updatedAt", skrg);

                da.UpdateCommand = cmd;
                buka_koneksi();
                res = da.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Produk barang berhasil diubah", "Edited");

                tutup_koneksi();
                panel1.Visible = false;
                txtId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
               
        }
    }
}
