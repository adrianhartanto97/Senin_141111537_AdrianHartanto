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
    public partial class frmDaftarSupplier : Form
    {
        static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=latihan_pos;Uid=root;password=;");
        public frmDaftarSupplier()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDaftarSupplier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lihatDaftarSupplier();
        }

        private void lihatDaftarSupplier()
        {
            MySqlDataAdapter da;
            DataSet ds;
            try
            {
                da = new MySqlDataAdapter("SELECT ID, Kode, Nama, Alamat FROM supplier", koneksi);
                ds = new DataSet();
                da.Fill(ds, "supplier");
                dgvSupplier.ReadOnly = true;
                dgvSupplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvSupplier.RowHeadersVisible = false;
                dgvSupplier.AllowUserToDeleteRows = false;
                dgvSupplier.AllowUserToAddRows = false;
                dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSupplier.DataSource = ds.Tables["supplier"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            lihatDaftarSupplier();
        }
    }
}
