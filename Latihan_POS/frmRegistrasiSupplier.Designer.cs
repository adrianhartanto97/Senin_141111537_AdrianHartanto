﻿namespace Latihan_POS
{
    partial class frmRegistrasiSupplier
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
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(244, 190);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 24;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(154, 190);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 23;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(62, 190);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(137, 123);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(182, 20);
            this.txtPhoneNumber.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Phone Number";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(137, 49);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(182, 20);
            this.txtAlamat.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Alamat";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(137, 12);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(182, 20);
            this.txtNama.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nama";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(137, 86);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(182, 20);
            this.txtZipcode.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Zip Code";
            // 
            // frmRegistrasiSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 264);
            this.ControlBox = false;
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZipcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnReset);
            this.Name = "frmRegistrasiSupplier";
            this.Text = "frmRegistrasiSupplier";
            this.Load += new System.EventHandler(this.frmRegistrasiSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label label1;
    }
}