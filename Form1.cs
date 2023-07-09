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
using System.Net.NetworkInformation;

namespace UAS_Kelompok20_PABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void masukanDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Peminjam dpm = new Data_Peminjam();
            dpm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void masukanDataFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kelompok_Film kfm = new Kelompok_Film();
            kfm.Show();
            this.Hide();
        }
    }
}
