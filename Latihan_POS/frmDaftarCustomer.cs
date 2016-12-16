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
    public partial class frmDaftarCustomer : Form
    {
        static MySqlConnection koneksi = new MySqlConnection("Server=localhost;Port=3306;Database=latihan_pos;Uid=root;password=;");
        public frmDaftarCustomer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDaftarCustomer_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lihatDaftarCustomer();
        }

        private void lihatDaftarCustomer()
        {
            MySqlDataAdapter da;
            DataSet ds;
            try
            {
                da = new MySqlDataAdapter("SELECT ID, Kode, Nama, Alamat FROM customer", koneksi);
                ds = new DataSet();
                da.Fill(ds, "customer");
                dgvCustomer.ReadOnly = true;
                dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                dgvCustomer.RowHeadersVisible = false;
                dgvCustomer.AllowUserToDeleteRows = false;
                dgvCustomer.AllowUserToAddRows = false;
                dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCustomer.DataSource = ds.Tables["customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            lihatDaftarCustomer();
        }
    }
}
