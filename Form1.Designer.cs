﻿namespace UAS_Kelompok20_PABD
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.masukanDataFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataKelompokFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masukanDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masukanDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masukanDataMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental DVD FILM";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Text = "Menu Utama";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masukanDataFilmToolStripMenuItem,
            this.dataKelompokFilmToolStripMenuItem,
            this.masukanDataPegawaiToolStripMenuItem,
            this.masukanDataToolStripMenuItem,
            this.masukanDataMemberToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // masukanDataFilmToolStripMenuItem
            // 
            this.masukanDataFilmToolStripMenuItem.Name = "masukanDataFilmToolStripMenuItem";
            this.masukanDataFilmToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.masukanDataFilmToolStripMenuItem.Text = "Masukan Data Film";
            this.masukanDataFilmToolStripMenuItem.Click += new System.EventHandler(this.masukanDataFilmToolStripMenuItem_Click);
            // 
            // dataKelompokFilmToolStripMenuItem
            // 
            this.dataKelompokFilmToolStripMenuItem.Name = "dataKelompokFilmToolStripMenuItem";
            this.dataKelompokFilmToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.dataKelompokFilmToolStripMenuItem.Text = "Data Kelompok Film";
            // 
            // masukanDataPegawaiToolStripMenuItem
            // 
            this.masukanDataPegawaiToolStripMenuItem.Name = "masukanDataPegawaiToolStripMenuItem";
            this.masukanDataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.masukanDataPegawaiToolStripMenuItem.Text = "Masukan Data Pegawai";
            // 
            // masukanDataToolStripMenuItem
            // 
            this.masukanDataToolStripMenuItem.Name = "masukanDataToolStripMenuItem";
            this.masukanDataToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.masukanDataToolStripMenuItem.Text = "Masukan Data Peminjam";
            this.masukanDataToolStripMenuItem.Click += new System.EventHandler(this.masukanDataToolStripMenuItem_Click);
            // 
            // masukanDataMemberToolStripMenuItem
            // 
            this.masukanDataMemberToolStripMenuItem.Name = "masukanDataMemberToolStripMenuItem";
            this.masukanDataMemberToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.masukanDataMemberToolStripMenuItem.Text = "Masukan Data Member";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem masukanDataFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataKelompokFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masukanDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masukanDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masukanDataMemberToolStripMenuItem;
    }
}

