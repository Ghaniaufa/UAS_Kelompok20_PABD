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
            btnDelete.Enabled = false;
            
        }
        
        public Data_Peminjam()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Peminjam";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Data_Peminjam_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtnop.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Peminjam WHERE no_peminjam = @no_peminjam";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@no_peminjam", txtDel.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil Dihapus");
                        dataGridView();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message + " (Error Code: " + ex.Number + ")");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

        }
    }
}
