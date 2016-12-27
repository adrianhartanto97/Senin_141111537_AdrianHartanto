namespace Latihan_POS
{
    partial class frmDetailPembelian
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
            this.dgvPembelian = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetailPembelian = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPembelian
            // 
            this.dgvPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPembelian.Location = new System.Drawing.Point(12, 33);
            this.dgvPembelian.Name = "dgvPembelian";
            this.dgvPembelian.Size = new System.Drawing.Size(511, 125);
            this.dgvPembelian.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pembelian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detail Pembelian";
            // 
            // dgvDetailPembelian
            // 
            this.dgvDetailPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPembelian.Location = new System.Drawing.Point(12, 213);
            this.dgvDetailPembelian.Name = "dgvDetailPembelian";
            this.dgvDetailPembelian.Size = new System.Drawing.Size(511, 125);
            this.dgvDetailPembelian.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDetailPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 391);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDetailPembelian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPembelian);
            this.Name = "frmDetailPembelian";
            this.Text = "frmDetailPembelian";
            this.Load += new System.EventHandler(this.frmDetailPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPembelian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembelian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPembelian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetailPembelian;
        private System.Windows.Forms.Button button1;
    }
}