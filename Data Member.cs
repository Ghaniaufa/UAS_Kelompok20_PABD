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
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Member";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxNombr.Enabled = true;
            tbxNmMbr.Enabled = true;
            tbxJlMbr.Enabled = true;
            tbxKtMbr.Enabled = true;
            tbxPMbr.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string noMember = tbxNombr.Text;
            string nmMember = tbxNmMbr.Text;
            string jlMember = tbxJlMbr.Text;
            string ktMember = tbxKtMbr.Text;
            string prMember = tbxPMbr.Text;

            if (noMember == "")
            {
                MessageBox.Show("Masukkan NO Member", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Member (no_member,nama_member,jalan_member,kota_member,provinsi_member)" + "values(@no_member,@nama_member,@jalan_member,@kota_member,@provinsi_member)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("no_member", noMember));
                cmd.Parameters.Add(new SqlParameter("nama_member", nmMember));
                cmd.Parameters.Add(new SqlParameter("jalan_member", jlMember));
                cmd.Parameters.Add(new SqlParameter("kota_member", ktMember));
                cmd.Parameters.Add(new SqlParameter("provinsi_member", prMember));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string str = "DELETE FROM Member WHERE no_member = @no_member";

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                using (SqlCommand cmd = new SqlCommand(str, conn))
                {
                    cmd.Parameters.AddWithValue("@no_member", tbxDelete.Text);

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
        private void Data_Peminjam_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fu = new Form1();
            fu.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 myForm1 = new Form1();
            myForm1.Show();
            this.Close();
        }
    }
}
