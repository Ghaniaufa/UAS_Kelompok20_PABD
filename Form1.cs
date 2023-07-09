using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Windows.Input;

namespace UAS_Kelompok20_PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tambah_Data td = new Tambah_Data();
            td.Show();
            this.Hide();
        }

        private void kelompokFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kelompok_Film kfm = new Kelompok_Film();
            kfm.Show();
            this.Hide();
        }
    }
}
