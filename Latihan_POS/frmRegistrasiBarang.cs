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
    public partial class frmRegistrasiBarang : Form
    {
        List<TextBox> listInput = new List<TextBox>();
        public frmRegistrasiBarang()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;         
        }

        private void frmRegistrasiBarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    listInput.Add((TextBox) ctrl);
            }

            try
            {
                Class.clsDatabase.buka_koneksi();
            }
            catch (MySqlException ec)
            {
                MessageBox.Show(ec.Message, "Error");
            }
        }

        private void frmRegistrasiBarang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Class.clsDatabase.tutup_koneksi();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Class.clsDatabase.tutup_koneksi();
            this.Close();
        }

        private bool validasi(List<TextBox> list)
        {
            bool v = true;
            foreach (TextBox item in list)
            {
                if (item.Text.Trim() == "")
                {
                    v = false;
                    break;
                }
            }
            return v;
        }

        private bool validasiKode(string teks)
        {
            MySqlCommand cmd = Class.clsDatabase.koneksi.CreateCommand();
            bool v = true;
            string query = "SELECT Kode from barang";
            cmd.CommandText = query;
            Class.clsDatabase.buka_koneksi();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == teks)
                {
                    v = false;
                    break;
                }
            }
            Class.clsDatabase.tutup_koneksi();
            return v;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (validasi(listInput))
            {
                if (validasiKode(txtKode.Text))
                {
                    try
                    {
                        Class.clsBarang BarangBaru = new Class.clsBarang(txtKode.Text, txtNama.Text, Convert.ToInt32(txtJlhAwal.Text), Convert.ToDecimal(txtHrgHPP.Text), Convert.ToDecimal(txtHargaJual.Text));
                        int res = BarangBaru.InsertBarang();
                        reset();
                        MessageBox.Show(res + " produk berhasil ditambahkan", "Tersimpan");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                else {
                    MessageBox.Show("Kode yang Anda masukkan sudah terdaftar, mohon ganti dengan kode lain"); 
                }
            }
            else
            {
                MessageBox.Show("Mohon Masukkan Data dengan Lengkap");
            }
        }

        private void reset()
        {
            txtKode.Clear();
            txtNama.Clear();
            txtJlhAwal.Clear();
            txtHrgHPP.Clear();
            txtHargaJual.Clear();
            txtKode.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
