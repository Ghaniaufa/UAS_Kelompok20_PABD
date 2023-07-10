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
    public partial class Data_Pemrosesan : Form
    {
        private string stringConnection = "Data Source=GHANIAUFA;Initial Catalog=TokoDVDFilm;Persist Security Info=True;User ID=sa;Password=Anjingan20";
        private SqlConnection koneksi;

        private void refreshform()
        {
            tbxKf.Text = "";
            tbxJmlDVD.Text = "";
            tbxNp.Text = "";
            tbxKf.Enabled = false;
            tbxJmlDVD.Enabled = false;
            tbxNp.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        public Data_Pemrosesan()
        {
            InitializeComponent();
        }

        private void Data_Pemrosesan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
