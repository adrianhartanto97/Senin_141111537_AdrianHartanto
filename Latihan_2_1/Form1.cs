using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime tglLahir = new DateTime(1997, 1, 24);
            monthCalendar1.AddBoldedDate(tglLahir);
            domainUpDown1.SelectedIndex = 0;

            DateTime libur = new DateTime(2016, 1, 1);
            while (libur.Year == 2016)
            {
                if (libur.DayOfWeek == DayOfWeek.Saturday || libur.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(libur);
                }
                libur = libur.AddDays(1);
            }
            monthCalendar1.UpdateBoldedDates();

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDown1.Text == "Januari" || domainUpDown1.Text == "Maret" || domainUpDown1.Text == "Mei" ||
                domainUpDown1.Text == "Juli" || domainUpDown1.Text == "Agustus" || domainUpDown1.Text == "Oktober" || domainUpDown1.Text == "Desember")
                numericUpDown1.Maximum = 31;
            else if (domainUpDown1.Text == "Februari")
                numericUpDown1.Maximum = 29;
            else
                numericUpDown1.Maximum = 30;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tglX = new DateTime(2016, domainUpDown1.SelectedIndex + 1, Convert.ToInt16(numericUpDown1.Value));
            monthCalendar1.AddAnnuallyBoldedDate(tglX);
            monthCalendar1.UpdateBoldedDates();
            monthCalendar1.SetDate(tglX);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tgl = monthCalendar1.SelectionRange.Start.Date;
            monthCalendar1.RemoveAnnuallyBoldedDate(tgl);
            monthCalendar1.UpdateBoldedDates();
        }
    }
}
