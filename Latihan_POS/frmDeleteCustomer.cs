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
    public partial class frmDeleteCustomer : Form
    {
        public frmDeleteCustomer()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void frmDeleteCustomer_Load(object sender, EventArgs e)
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
                    Class.clsCustomer CustomerHapus = new Class.clsCustomer(Convert.ToInt16(txtId.Text));
                    res = CustomerHapus.DeleteCustomer();
                    txtId.Text = "";
                    MessageBox.Show("Customer berhasil dihapus", "Deleted");
                }
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
