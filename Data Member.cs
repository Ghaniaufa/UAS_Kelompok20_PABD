using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_Kelompok20_PABD
{
    public partial class Data_Member : Form
    {
        private string stringConnection = "Data Source=GHANIAUFA;Initial Catalog=TokoDVDFilm;Persist Security Info=True;User ID=sa;Password=Anjingan20";
        private SqlConnection koneksi;

        private void refreshform()
        {
            tbxNombr.Text = "";
            tbxNmMbr.Text = "";
            tbxJlMbr.Text = "";
            tbxKtMbr.Text = "";
            tbxPMbr.Text = "";
            tbxNombr.Enabled = false;
            tbxNmMbr.Enabled = false;
            tbxJlMbr.Enabled = false;
            tbxKtMbr.Enabled = false;
            tbxPMbr.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }
        public Data_Member()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
