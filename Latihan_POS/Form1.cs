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
    public partial class frmMain : Form
    {
        frmRegistrasiBarang frmRegistrasiBarang;
        
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
            frmRegistrasiBarang.Show();
        }
    }
}