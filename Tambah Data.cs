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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UAS_Kelompok20_PABD
{
    public partial class Tambah_Data : Form
    {
        private string stringConnection = "Data Source=GHANIAUFA;Initial Catalog=TokoDVDFilm;Persist Security Info=True;User ID=sa;Password=Anjingan20";
        private SqlConnection koneksi;

        private void refreshform()
        {
            tbxJdl.Text = "";
            tbxKdfillm.Text = "";
            tbxJdl.Enabled = false;
            tbxJdl.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }
        public Tambah_Data()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.DVDFilm";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Tambah_Data_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxJdl.Enabled = true;
            tbxKdfillm.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            string Jdl = tbxJdl.Text;
            string kdFilm = tbxKdfillm.Text;


            if (kdFilm == "")
            {
                MessageBox.Show("Masukkan Kode Film", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.DVDfilm (judul,kode_film)" + "values(@judul,@kode_film)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("judul", Jdl));
                cmd.Parameters.Add(new SqlParameter("kode_film", kdFilm));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
        private void Data_Peminjam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fu = new Form1();
            fu.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = "UPDATE DVDFilm SET kode_film= @kode_film,judul= @judul WHERE kode_film=@kode_film";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@kode_film", tbxKdfillm.Text);
                    cmd.Parameters.AddWithValue("@judul", tbxJdl.Text);


                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Berhasil di Updated");
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
