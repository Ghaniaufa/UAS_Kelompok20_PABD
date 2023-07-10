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
    public partial class Kelompok_Film : Form
    {

        private string stringConnection = "Data Source=GHANIAUFA;Initial Catalog=TokoDVDFilm;Persist Security Info=True;User ID=sa;Password=Anjingan20";
        private SqlConnection koneksi;
        private void refreshform()
        {
            tbxJenisfilm.Text = "";
            tbxHs.Text = "";
            tbxNofilm.Text = "";
            tbxKodefilm.Text = "";
            tbxJenisfilm.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;

        }


        public Kelompok_Film()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Kelompok_film";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Kelompok_Film_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxJenisfilm.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string jenisFilm = tbxJenisfilm.Text;
            string hargaSewa = tbxHs.Text;
            string noFilm = tbxNofilm.Text;
            string kdFilm = tbxKodefilm.Text;

            if (jenisFilm == "")
            {
                MessageBox.Show("Masukkan Jenis Film", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Kelompok_film (jenis_film,harga_sewa,no_film,kode_film)" + "values(@jenis_film,@harga_sewa,@no_film,@kode_film)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("jenis_film", jenisFilm));
                cmd.Parameters.Add(new SqlParameter("harga_sewa", hargaSewa));
                cmd.Parameters.Add(new SqlParameter("no_film", noFilm));
                cmd.Parameters.Add(new SqlParameter("kode_film", kdFilm));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshform();
                dataGridView();
            }
        }
        private void Data_Peminjam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fu = new Form1();
            fu.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Kelompok_film WHERE no_film = @no_film";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@no_film", tbxDelete.Text);

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

        private void tbxDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
