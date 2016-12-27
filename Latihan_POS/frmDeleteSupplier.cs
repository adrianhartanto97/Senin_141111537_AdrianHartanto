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
    public partial class frmDeleteSupplier : Form
    {
        public frmDeleteSupplier()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDeleteSupplier_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                int res;
                DialogResult rslt;
                rslt = MessageBox.Show("Apakah Anda yakin ?", "Yakin?", MessageBoxButtons.YesNo);

                if (rslt == DialogResult.Yes)
                {
                    Class.clsSupplier SupplierHapus = new Class.clsSupplier(Convert.ToInt16(txtId.Text));
                    res = SupplierHapus.DeleteSupplier();
                    txtId.Text = "";
                    MessageBox.Show("Supplier berhasil dihapus", "Deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
