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
    public partial class Data_Peminjam : Form
    {
        private string stringConnection = "Data Source=GHANIAUFA\\GHANAUFA;Initial Catalog=TokoDVDFilm;User ID=sa;Password=Anjingan20";
        private SqlConnection koneksi;
        private void refreshform()
        {
            txtnop.Text = "";
            txtnp.Text = "";
            txtjlnp.Text = "";
            txtKp.Text = "";
            txtpp.Text = "";
            txtnop.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            
        }
        
        public Data_Peminjam()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
        }

        private void Data_Peminjam_Load(object sender, EventArgs e)
        {

        }
    }
}
