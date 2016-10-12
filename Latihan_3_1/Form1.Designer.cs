namespace Latihan_3_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.tombol_bold = new System.Windows.Forms.ToolStripButton();
            this.tombol_italic = new System.Windows.Forms.ToolStripButton();
            this.tombol_underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.tombol_bold,
            this.tombol_italic,
            this.tombol_underline,
            this.toolStripComboBox2,
            this.toolStripComboBox3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(476, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(75, 27);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // tombol_bold
            // 
            this.tombol_bold.CheckOnClick = true;
            this.tombol_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tombol_bold.Image = global::Latihan_3_1.Properties.Resources.bold;
            this.tombol_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tombol_bold.Name = "tombol_bold";
            this.tombol_bold.Size = new System.Drawing.Size(23, 24);
            this.tombol_bold.Text = "B";
            this.tombol_bold.Click += new System.EventHandler(this.tombol_bold_Click);
            // 
            // tombol_italic
            // 
            this.tombol_italic.CheckOnClick = true;
            this.tombol_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tombol_italic.Image = ((System.Drawing.Image)(resources.GetObject("tombol_italic.Image")));
            this.tombol_italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tombol_italic.Name = "tombol_italic";
            this.tombol_italic.Size = new System.Drawing.Size(23, 24);
            this.tombol_italic.Text = "toolStripButton2";
            this.tombol_italic.Click += new System.EventHandler(this.tombol_italic_Click);
            // 
            // tombol_underline
            // 
            this.tombol_underline.CheckOnClick = true;
            this.tombol_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tombol_underline.Image = global::Latihan_3_1.Properties.Resources.underline;
            this.tombol_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tombol_underline.Name = "tombol_underline";
            this.tombol_underline.Size = new System.Drawing.Size(23, 24);
            this.tombol_underline.Text = "toolStripButton3";
            this.tombol_underline.Click += new System.EventHandler(this.tombol_underline_Click);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(180, 27);
            this.toolStripComboBox2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(467, 324);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.richTextBox1_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 352);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton tombol_bold;
        private System.Windows.Forms.ToolStripButton tombol_italic;
        private System.Windows.Forms.ToolStripButton tombol_underline;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

