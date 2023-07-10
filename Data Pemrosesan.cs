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
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Pemrosesan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Data_Pemrosesan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxidp.Enabled = true;
            tbxKf.Enabled = true;
            tbxJmlDVD.Enabled = true;
            tbxNp.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idPemrosesan = tbxidp.Text;
            string KodeFilm = tbxKf.Text;
            string JmlD = tbxJmlDVD.Text;
            string noPegawai = tbxNp.Text;

            if (idPemrosesan == "")
            {
                MessageBox.Show("Masukkan ID Peminjam", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Pemrosesan (id_pemrosesan,kode_film,jumlah_DVD,no_pegawai)" + "values(@id_pemrosesan,@kode_film,@jumlah_DVD,@no_pegawai)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_pemrosesan", KodeFilm));
                cmd.Parameters.Add(new SqlParameter("kode_film", KodeFilm));
                cmd.Parameters.Add(new SqlParameter("jumlah_DVD", JmlD));
                cmd.Parameters.Add(new SqlParameter("no_pegawai", noPegawai));
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Pemrosesan WHERE id_pemrosesan = @id_pemrosesan";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pemrosesan", tbxDelete.Text);

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
