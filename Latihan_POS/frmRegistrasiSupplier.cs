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
    public partial class frmRegistrasiSupplier : Form
    {
        List<TextBox> listInput = new List<TextBox>();
        static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=latihan_pos;Uid=root;password=;");
        public frmRegistrasiSupplier()
        {
            InitializeComponent();
        }

        private void frmRegistrasiSupplier_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    listInput.Add((TextBox)ctrl);
            }

            try
            {
                koneksi.Open();
            }
            catch (MySqlException ec)
            {
                MessageBox.Show(ec.Message, "Error");
            }
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

        private void reset()
        {
            txtKode.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            tutup_koneksi();
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
            MySqlCommand cmd = koneksi.CreateCommand();
            bool v = true;
            string query = "SELECT Kode from customer";
            cmd.CommandText = query;
            buka_koneksi();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == teks)
                {
                    v = false;
                    break;
                }
            }
            tutup_koneksi();
            return v;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (validasi(listInput))
            {
                if (validasiKode(txtKode.Text))
                {
                    DateTime skrg = DateTime.Now;
                    MySqlCommand cmd = koneksi.CreateCommand();
                    string insert = "INSERT INTO supplier (Kode,Nama,Alamat,created_at,updated_at)";
                    insert += " VALUES (@kode,@nama,@alamat,@createdAt,@updatedAt)";
                    try
                    {
                        cmd.CommandText = insert;
                        cmd.Parameters.AddWithValue("@kode", txtKode.Text);
                        cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                        cmd.Parameters.AddWithValue("@createdAt", skrg);
                        cmd.Parameters.AddWithValue("@updatedAt", skrg);

                        reset();
                        buka_koneksi();
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result + " Supplier Berhasil Ditambahkan", "Sukses");
                        tutup_koneksi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Kode yang Anda masukkan sudah terdaftar, mohon ganti dengan kode lain");
                }
            }
            else
            {
                MessageBox.Show("Mohon Masukkan Data dengan Lengkap");
            }
        }
    }
}
