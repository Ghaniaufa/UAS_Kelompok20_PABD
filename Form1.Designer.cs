namespace UAS_Kelompok20_PABD
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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kelompokFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPeminjamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPemrosesanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataFilmToolStripMenuItem,
            this.kelompokFilmToolStripMenuItem,
            this.dataPeminjamToolStripMenuItem,
            this.dataMemberToolStripMenuItem,
            this.dataTransaksiToolStripMenuItem,
            this.dataPemrosesanToolStripMenuItem,
            this.dataPegawaiToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(54, 22);
            this.toolStripDropDownButton1.Text = "MENU";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // dataFilmToolStripMenuItem
            // 
            this.dataFilmToolStripMenuItem.Name = "dataFilmToolStripMenuItem";
            this.dataFilmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataFilmToolStripMenuItem.Text = "Data Film";
            this.dataFilmToolStripMenuItem.Click += new System.EventHandler(this.dataFilmToolStripMenuItem_Click);
            // 
            // kelompokFilmToolStripMenuItem
            // 
            this.kelompokFilmToolStripMenuItem.Name = "kelompokFilmToolStripMenuItem";
            this.kelompokFilmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kelompokFilmToolStripMenuItem.Text = "Kelompok Film";
            this.kelompokFilmToolStripMenuItem.Click += new System.EventHandler(this.kelompokFilmToolStripMenuItem_Click);
            // 
            // dataPeminjamToolStripMenuItem
            // 
            this.dataPeminjamToolStripMenuItem.Name = "dataPeminjamToolStripMenuItem";
            this.dataPeminjamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPeminjamToolStripMenuItem.Text = "Data Peminjam";
            this.dataPeminjamToolStripMenuItem.Click += new System.EventHandler(this.dataPeminjamToolStripMenuItem_Click);
            // 
            // dataMemberToolStripMenuItem
            // 
            this.dataMemberToolStripMenuItem.Name = "dataMemberToolStripMenuItem";
            this.dataMemberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataMemberToolStripMenuItem.Text = "Data Member";
            this.dataMemberToolStripMenuItem.Click += new System.EventHandler(this.dataMemberToolStripMenuItem_Click);
            // 
            // dataTransaksiToolStripMenuItem
            // 
            this.dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            this.dataTransaksiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            // 
            // dataPemrosesanToolStripMenuItem
            // 
            this.dataPemrosesanToolStripMenuItem.Name = "dataPemrosesanToolStripMenuItem";
            this.dataPemrosesanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPemrosesanToolStripMenuItem.Text = "Data Pemrosesan";
            // 
            // dataPegawaiToolStripMenuItem
            // 
            this.dataPegawaiToolStripMenuItem.Name = "dataPegawaiToolStripMenuItem";
            this.dataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataPegawaiToolStripMenuItem.Text = "Data Pegawai";
            this.dataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.dataPegawaiToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumOrchid;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(233, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "RENTALDVD FILM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "RENTAL DVD";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem dataFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kelompokFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPeminjamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPemrosesanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPegawaiToolStripMenuItem;
    }
}