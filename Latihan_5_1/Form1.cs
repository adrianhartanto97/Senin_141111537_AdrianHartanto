using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Latihan_5_1
{
    public partial class Form1 : Form
    {
        public bool isSave = true;
        public string direktoriSave = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection kumpulanfont = new InstalledFontCollection();
            foreach (FontFamily i in kumpulanfont.Families)
            {
                toolStripComboBox2.Items.Add(i.Name);
            }
            toolStripComboBox2.SelectedIndex = 14;

            for (int i = 5; i <= 72; i++)
                toolStripComboBox1.Items.Add(i);
            toolStripComboBox1.SelectedIndex = 7;

            toolStripComboBox2.ComboBox.LostFocus += new EventHandler(toolStripComboBox2_LostFocus);
            toolStripComboBox1.ComboBox.LostFocus += new EventHandler(toolStripComboBox2_LostFocus);
            toolStripComboBox2.ComboBox.DrawItem += new DrawItemEventHandler(toolStripComboBox2_DrawItem);
            toolStripComboBox2.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                {
                    toolStripComboBox3.Items.Add(property.Name);
                    toolStripComboBox4.Items.Add(property.Name);
                }
            }

            toolStripComboBox3.SelectedIndex = 8;
            toolStripComboBox3.ComboBox.LostFocus += new EventHandler(toolStripComboBox3_LostFocus);
            toolStripComboBox3.ComboBox.DrawItem += new DrawItemEventHandler(toolStripComboBox3_DrawItem);
            toolStripComboBox3.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            toolStripComboBox4.Text = "White";
            richTextBox1.SelectionBackColor = Color.FromName(toolStripComboBox4.Text);
            toolStripComboBox4.ComboBox.LostFocus += new EventHandler(toolStripComboBox4_LostFocus);
            toolStripComboBox4.ComboBox.DrawItem += new DrawItemEventHandler(toolStripComboBox3_DrawItem);
            toolStripComboBox4.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            update_teks();
        }

        public string getBackgroundColor()
        {
            return richTextBox1.BackColor.Name;
        }

        public void setBackgroundColor(string color)
        {
            richTextBox1.BackColor = Color.FromName(color);
            richTextBox1.SelectionBackColor = richTextBox1.BackColor;
        }

        private void toolStripComboBox2_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(toolStripComboBox2.Items[e.Index].ToString(), new Font(toolStripComboBox2.Items[e.Index].ToString(), toolStripComboBox2.Font.Size), Brushes.Black, e.Bounds);
        }

        private void toolStripComboBox3_DrawItem(object sender, DrawItemEventArgs e)
        {
            // a dropdownlist may initially have no item selected, so skip the highlighting:
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.toolStripComboBox3.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                // Draw a rectangle and fill it with the current color
                // and add the name to the right of the color
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }


        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            update_teks();
        }


        public void update_teks()
        {

            bool isBold, isItalic, isUnderline;
            int length = richTextBox1.SelectionLength;
            int start = richTextBox1.SelectionStart;
            float fontSize;
            string fontFamily;
            //System.Drawing.FontStyle currentStyle;
            this.richTextBox1.SelectionChanged -= new System.EventHandler(this.richTextBox1_SelectionChanged);
            if (length == 0)
            {
                fontFamily = (toolStripComboBox2.Text == "") ? richTextBox1.SelectionFont.FontFamily.Name : toolStripComboBox2.Text;
                fontSize = (toolStripComboBox1.Text == "") ? richTextBox1.SelectionFont.Size : Convert.ToSingle(toolStripComboBox1.Text);
                FontStyle style = (tombol_bold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (tombol_italic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (tombol_underline.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font baru = new Font(fontFamily, fontSize, style);
                richTextBox1.SelectionFont = baru;
            }
            for (int i = start; i < start + length; i++)
            {
                richTextBox1.SelectionChanged -= new System.EventHandler(this.richTextBox1_SelectionChanged);
                richTextBox1.Select(i, 1);
                fontFamily = (toolStripComboBox2.Text == "") ? richTextBox1.SelectionFont.FontFamily.Name : toolStripComboBox2.Text;
                fontSize = (toolStripComboBox1.Text == "") ? richTextBox1.SelectionFont.Size : Convert.ToSingle(toolStripComboBox1.Text);

                isBold = richTextBox1.SelectionFont.Bold;
                isItalic = richTextBox1.SelectionFont.Italic;
                isUnderline = richTextBox1.SelectionFont.Underline;

                FontStyle style = (tombol_bold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (tombol_italic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (tombol_underline.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font baru = new Font(fontFamily, fontSize, style);
                richTextBox1.SelectionFont = baru;
            }

            richTextBox1.Select(start, length);
            richTextBox1.Focus();

            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            update_teks();
           
        }

        private void tombol_bold_Click(object sender, EventArgs e)
        {
            update_teks();
        }

        private void tombol_italic_Click(object sender, EventArgs e)
        {
            update_teks();
        }

        private void tombol_underline_Click(object sender, EventArgs e)
        {
            update_teks();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            tombol_bold.Checked = false;
            tombol_italic.Checked = false;
            tombol_underline.Checked = false;

            if (richTextBox1.SelectionFont != null)
            {
                try
                {
                    toolStripComboBox2.SelectedItem = richTextBox1.SelectionFont.FontFamily.Name;
                }
                catch
                {
                    toolStripComboBox2.Text = "";
                }

                //try
                //{
                      toolStripComboBox1.Text = richTextBox1.SelectionFont.Size.ToString();
                //}
               // catch { toolStripComboBox1.Text = ""; }

                /*
                try
                {
                    toolStripComboBox3.SelectedItem = richTextBox1.SelectionColor.Name;
                }
                catch
                {
                    toolStripComboBox3.Text = "";
                }*/

                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Bold") != -1)
                    tombol_bold.Checked = true;

                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Italic") != -1)
                    tombol_italic.Checked = true;

                if (richTextBox1.SelectionFont.Style.ToString().IndexOf("Underline") != -1)
                    tombol_underline.Checked = true;
            }
            else
            {
                toolStripComboBox1.Text = "";
                toolStripComboBox2.Text = "";
            }

            if (richTextBox1.SelectionColor.Name == "0")
            {
                toolStripComboBox3.Text = "Black";
            }
            else
            {
                toolStripComboBox3.Text = richTextBox1.SelectionColor.Name;
            }
            toolStripComboBox4.Text = richTextBox1.BackColor.Name;
        }


        private void toolStripComboBox2_LostFocus(object sender, EventArgs e)
        {
            update_teks();
        }

        private void toolStripComboBox3_LostFocus(object sender, EventArgs e)
        {
            int length = richTextBox1.SelectionLength;
            int start = richTextBox1.SelectionStart;
            richTextBox1.SelectionColor = Color.FromName(toolStripComboBox3.Text);
            richTextBox1.Select(start, length);
        }

        private void toolStripComboBox4_LostFocus(object sender, EventArgs e)
        {
            int length = richTextBox1.SelectionLength;
            int start = richTextBox1.SelectionStart;
            richTextBox1.SelectionBackColor = Color.FromName(toolStripComboBox4.Text);
            richTextBox1.Select(start, length);
        }


        private void simpan()
        {
            DialogResult dr;
            if (direktoriSave == "")
            {
                saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
                dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    direktoriSave = saveFileDialog1.FileName;
                }
            }
            else
            {
                 richTextBox1.SaveFile(direktoriSave);
            }
            isSave = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                simpan();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
            dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                direktoriSave = saveFileDialog1.FileName;
            }
            isSave = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                if (!isSave)
                {
                    dr = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dr == DialogResult.Yes)
                    {
                        simpan();
                    }
                }
                dr = openFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    direktoriSave = openFileDialog1.FileName;
                    isSave = true;
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isSave = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr;
                if (!isSave)
                {
                    dr = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dr == DialogResult.Yes)
                    {
                        simpan();
                    }
                }

                richTextBox1.Clear();
                direktoriSave = "";
                isSave = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void keluar()
        {
            if (!isSave)
            {
                DialogResult dr;
                dr = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    Application.ExitThread();
                }
                else if (dr == DialogResult.Yes)
                {
                    simpan();
                    Application.ExitThread();
                }
            }
            else
                Application.ExitThread();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            keluar();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            keluar();
        }

        private void toolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = richTextBox1.SelectionLength;
            int start = richTextBox1.SelectionStart;
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            richTextBox1.SelectionColor = Color.FromName(toolStripComboBox3.Text);
            richTextBox1.Focus();
            richTextBox1.Select(start, length);
        }

        private void toolStripComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int length = richTextBox1.SelectionLength;
            int start = richTextBox1.SelectionStart;
            ToolStripComboBox x = (ToolStripComboBox)sender;
            if (!x.Focused)
                return;
            richTextBox1.SelectionBackColor = Color.FromName(toolStripComboBox4.Text);
            richTextBox1.Focus();
            richTextBox1.Select(start, length);
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (richTextBox1.SelectionLength == 0)
                {
                    contextMenuStrip1.Items[0].Enabled = false;
                    contextMenuStrip1.Items[1].Enabled = false;
                    contextMenuStrip1.Items[3].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items[0].Enabled = true;
                    contextMenuStrip1.Items[1].Enabled = true;
                    contextMenuStrip1.Items[3].Enabled = true;
                }
                contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                richTextBox1.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
            {
                return;
            }

            richTextBox1.SelectedText = "";
        }

        FormSettingEditor formEditor;
        private void editorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (formEditor == null || !formEditor.IsHandleCreated)
            {
                formEditor = new FormSettingEditor();
                formEditor.MdiParent = this;
                formEditor.BringToFront();
                richTextBox1.SendToBack();
                formEditor.Show();
            }
            else
            {
                formEditor.Show();
            }
        }
        public void showRTB()
        {
            richTextBox1.BringToFront();
            richTextBox1.Focus();
        }

    }
}
