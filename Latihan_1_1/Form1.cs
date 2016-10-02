using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Form1 : Form
    {
        List<Label> kumpulanLabel = new List<Label>();
        List<Label> kumpulanLabelv2 = new List<Label>();
        public Form1()
        {
            InitializeComponent();
            kumpulanLabel.Add(label5);
            kumpulanLabel.Add(label6);
            kumpulanLabel.Add(label7);
            kumpulanLabel.Add(label8);
            kumpulanLabel.Add(label3);
            kumpulanLabel.Add(label4);

            kumpulanLabelv2.Add(label9); kumpulanLabelv2.Add(label10);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int x = Convert.ToInt16((sender as ScrollBar).Name.Substring(10, 1));
            x--;
            kumpulanLabel[x].Text = (sender as ScrollBar).Value.ToString();
            bool kirikanan = x%2 == 0? true:false;
            if (kirikanan)
                kumpulanLabel[4 + (x / 2)].Text = kumpulanLabel[x].Text + kumpulanLabel[x + 1].Text;
            else
                kumpulanLabel[4 + (x / 2)].Text = kumpulanLabel[x-1].Text + kumpulanLabel[x].Text;

            if (x / 2 == 0)
            {
                DateTime minimal = new DateTime((DateTime.Today.Year - Convert.ToInt16(kumpulanLabel[4 + (x / 2)].Text)), DateTime.Today.Month, DateTime.Today.Day);
                dateTimePicker1.MinDate = minimal;
            }
            else
            {
                DateTime maksimal = new DateTime((DateTime.Today.Year + Convert.ToInt16(kumpulanLabel[4 + (x / 2)].Text)), DateTime.Today.Month, DateTime.Today.Day);
                dateTimePicker1.MaxDate = maksimal;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.tabControl1.TabPages[0].Controls)
            {
                if (ctrl is VScrollBar)
                {
                    (ctrl as VScrollBar).Scroll += new ScrollEventHandler(vScrollBar1_Scroll);
                }
            }

            foreach (Control ctrl in this.tabControl1.TabPages[1].Controls)
            {
                if (ctrl is HScrollBar)
                {
                    (ctrl as HScrollBar).Scroll += new ScrollEventHandler(hScrollBar1_Scroll);
                }
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int x = Convert.ToInt16((sender as ScrollBar).Name.Substring(10, 1));
            x--;
            kumpulanLabelv2[x].Text = (sender as ScrollBar).Value.ToString();
            string s = kumpulanLabelv2[0].Text + kumpulanLabelv2[1].Text;
            textBox1.Text = s;
            int range = Convert.ToInt16(s);
            DateTime minimal = new DateTime(DateTime.Today.Year - range, DateTime.Today.Month, DateTime.Today.Day);
            DateTime maksimal = new DateTime(DateTime.Today.Year + range, DateTime.Today.Month, DateTime.Today.Day);
            textBox2.Text = minimal.ToShortDateString();
            textBox3.Text = maksimal.ToShortDateString();
            dateTimePicker2.MinDate = minimal;
            dateTimePicker2.MaxDate = maksimal;
        }
    }
}
