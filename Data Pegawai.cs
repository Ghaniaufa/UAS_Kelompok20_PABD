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
    public partial class Data_Pegawai : Form
    {
        private string stringConnection = "Data Source=GHANIAUFA;Initial Catalog=TokoDVDFilm;Persist Security Info=True;User ID=sa;Password=Anjingan20";
        private SqlConnection koneksi;

        private void refreshform()
        {
            tbxNP.Text = "";
            tbxNmP.Text = "";
            tbxJp.Text = "";
            tbxKp.Text = "";
            tbxPP.Text = "";
            tbxNP.Enabled = false;
            tbxNmP.Enabled = false;
            tbxJp.Enabled = false;
            tbxKp.Enabled = false;
            tbxPP.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        public Data_Pegawai()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Pegawai";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Data_Pegawai_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxNP.Enabled = true;
            tbxNmP.Enabled = true;
            tbxJp.Enabled = true;
            tbxKp.Enabled = true;
            tbxPP.Enabled = true;
            btnClear.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noPegawai = tbxNP.Text;
            string nmPegawai = tbxNmP.Text;
            string jlPegawai = tbxJp.Text;
            string ktPegawai = tbxKp.Text;
            string prPegawai = tbxPP.Text;

            if (noPegawai == "")
            {
                MessageBox.Show("Masukkan NO Pegawai", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Pegawai (no_pegawai,nama_pegawai,jalan_pegawai,kota_pegawai,provinsi_pegawai)" + "values(@no_pegawai,@nama_pegawai,@jalan_pegawai,@kota_pegawai,@provinsi_pegawai)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("no_pegawai", noPegawai));
                cmd.Parameters.Add(new SqlParameter("nama_pegawai", nmPegawai));
                cmd.Parameters.Add(new SqlParameter("jalan_pegawai", jlPegawai));
                cmd.Parameters.Add(new SqlParameter("kota_pegawai", ktPegawai));
                cmd.Parameters.Add(new SqlParameter("provinsi_pegawai", prPegawai));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Pegawai WHERE no_pegawai = @no_pegawai";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@no_pegawai", tbxDelete.Text);

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fu = new Form1();
            fu.Show();
            this.Close();
        }
    }
}
