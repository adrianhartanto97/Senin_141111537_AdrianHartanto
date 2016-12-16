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
    public partial class frmDaftarBarang : Form
    {
        static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=latihan_pos;Uid=root;password=;");
        public frmDaftarBarang()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDaftarBarang_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lihatDaftarBarang();
        }

        private void lihatDaftarBarang()
        {
            MySqlDataAdapter da;
            DataSet ds;
            try
            {
                da = new MySqlDataAdapter("SELECT ID, Kode, Nama, JumlahAwal, HargaHPP, HargaJual FROM barang", koneksi);
                ds = new DataSet();
                da.Fill(ds, "barang");
                dgvBarang.ReadOnly = true;
                dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvBarang.RowHeadersVisible = false;
                dgvBarang.AllowUserToDeleteRows = false;
                dgvBarang.AllowUserToAddRows = false;
                dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBarang.DataSource = ds.Tables["barang"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void refresh_Click(object sender, EventArgs e)
        {
            lihatDaftarBarang();
        }
    }
}
