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
    public partial class frmMain : Form
    {
        frmRegistrasiBarang frmRegistrasiBarang;
        frmDaftarBarang frmDaftarBarang;
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRegistrasiBarang == null || !frmRegistrasiBarang.IsHandleCreated)
            {
                frmRegistrasiBarang = new frmRegistrasiBarang();
                frmRegistrasiBarang.MdiParent = this;
            }
            frmRegistrasiBarang.BringToFront();
            frmRegistrasiBarang.Show();
        }

        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmDaftarBarang == null || !frmDaftarBarang.IsHandleCreated)
            {
                frmDaftarBarang = new frmDaftarBarang();
                frmDaftarBarang.MdiParent = this;
            }
            frmDaftarBarang.BringToFront();
            frmDaftarBarang.Show();
        }

        frmEditBarang frmEditBarang;
        private void barangToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmEditBarang == null || !frmEditBarang.IsHandleCreated)
            {
                frmEditBarang = new frmEditBarang();
                frmEditBarang.MdiParent = this;
            }
            frmEditBarang.BringToFront();
            frmEditBarang.Show();
        }

        frmDeleteBarang frmDeleteBarang;
        private void barangToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (frmDeleteBarang == null || !frmDeleteBarang.IsHandleCreated)
            {
                frmDeleteBarang = new frmDeleteBarang();
                frmDeleteBarang.MdiParent = this;
            }
            frmDeleteBarang.BringToFront();
            frmDeleteBarang.Show();
        }

        frmRegistrasiCustomer frmRegistrasiCustomer;
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRegistrasiCustomer == null || !frmRegistrasiCustomer.IsHandleCreated)
            {
                frmRegistrasiCustomer = new frmRegistrasiCustomer();
                frmRegistrasiCustomer.MdiParent = this;
            }
            frmRegistrasiCustomer.BringToFront();
            frmRegistrasiCustomer.Show();
        }

        frmDaftarCustomer frmDaftarCustomer;
        private void customerToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (frmDaftarCustomer == null || !frmDaftarCustomer.IsHandleCreated)
            {
                frmDaftarCustomer = new frmDaftarCustomer();
                frmDaftarCustomer.MdiParent = this;
            }
            frmDaftarCustomer.BringToFront();
            frmDaftarCustomer.Show();
        }

        frmEditCustomer frmEditCustomer;
        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmEditCustomer == null || !frmEditCustomer.IsHandleCreated)
            {
                frmEditCustomer = new frmEditCustomer();
                frmEditCustomer.MdiParent = this;
            }
            frmEditCustomer.BringToFront();
            frmEditCustomer.Show();
        }

        frmDeleteCustomer frmDeleteCustomer;
        private void customerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmDeleteCustomer == null || !frmDeleteCustomer.IsHandleCreated)
            {
                frmDeleteCustomer = new frmDeleteCustomer();
                frmDeleteCustomer.MdiParent = this;
            }
            frmDeleteCustomer.BringToFront();
            frmDeleteCustomer.Show();
        }

        frmRegistrasiSupplier frmRegistrasiSupplier;
        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRegistrasiSupplier == null || !frmRegistrasiSupplier.IsHandleCreated)
            {
                frmRegistrasiSupplier = new frmRegistrasiSupplier();
                frmRegistrasiSupplier.MdiParent = this;
            }
            frmRegistrasiSupplier.BringToFront();
            frmRegistrasiSupplier.Show();
        }

        frmDaftarSupplier frmDaftarSupplier;
        private void supplierToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (frmDaftarSupplier == null || !frmDaftarSupplier.IsHandleCreated)
            {
                frmDaftarSupplier = new frmDaftarSupplier();
                frmDaftarSupplier.MdiParent = this;
            }
            frmDaftarSupplier.BringToFront();
            frmDaftarSupplier.Show();
        }

        frmEditSupplier frmEditSupplier;
        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmEditSupplier == null || !frmEditSupplier.IsHandleCreated)
            {
                frmEditSupplier = new frmEditSupplier();
                frmEditSupplier.MdiParent = this;
            }
            frmEditSupplier.BringToFront();
            frmEditSupplier.Show();
        }

        frmDeleteSupplier frmDeleteSupplier;
        private void supplierToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (frmDeleteSupplier == null || !frmDeleteSupplier.IsHandleCreated)
            {
                frmDeleteSupplier = new frmDeleteSupplier();
                frmDeleteSupplier.MdiParent = this;
            }
            frmDeleteSupplier.BringToFront();
            frmDeleteSupplier.Show();
        }


    }
}
