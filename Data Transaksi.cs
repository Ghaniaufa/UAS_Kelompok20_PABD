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
    public partial class Data_Transaksi : Form
    {
        private string stringConnection = "Data Source=GHANIAUFA;Initial Catalog=TokoDVDFilm;Persist Security Info=True;User ID=sa;Password=Anjingan20";
        private SqlConnection koneksi;
        private SqlCommand command;
        private SqlDataAdapter adapter;


        public Data_Transaksi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            dataGridView();
            LoadPeminjamData();
            Kode_film();

        }

        private void refreshform()
        {
            tbxNoT.Text = "";
            cbxKf.Text = "";
            cbxNp.Text = "";
            dtpP.Text = "";
            dtpPn.Text = "";
            dtpP.Enabled = false;
            dtpPn.Enabled = false;
            tbxNoT.Enabled = false;
            cbxKf.Enabled = false;
            cbxNp.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Data_Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxNoT.Enabled = true;
            cbxKf.Enabled = true;
            cbxNp.Enabled = true;
            dtpP.Enabled = true;
            dtpPn.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Transaksi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string noTransaksi = tbxNoT.Text;
            string KdFilm = cbxKf.Text;
            string noPeminjam = cbxNp.Text;
            string Peminjaman = dtpP.Text;
            string Pengembalian = dtpPn.Text;

            if (noTransaksi == "")
            {
                MessageBox.Show("Masukkan NO Transaksi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO Transaksi (kode_film,no_peminjam,no_transaksi,tgl_pinjam,tgl_pengembalian)" + "values(@kode_film,@no_peminjam,@no_transaksi,@tgl_pinjam,@tgl_pengembalian)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("kode_film", KdFilm));
                cmd.Parameters.Add(new SqlParameter("no_peminjam", noPeminjam));
                cmd.Parameters.Add(new SqlParameter("no_transaksi", noTransaksi));
                cmd.Parameters.Add(new SqlParameter("tgl_pinjam", Peminjaman));
                cmd.Parameters.Add(new SqlParameter("tgl_pengembalian", Pengembalian));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Transaksi Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
        private void LoadPeminjamData()
        {
            try
            {
                koneksi.Open();

                string str = "SELECT no_peminjam FROM Peminjam";
                command = new SqlCommand(str, koneksi);
                DataTable peminjamTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(peminjamTable);

                cbxNp.DisplayMember = "no_peminjam";
                cbxNp.ValueMember = "no_peminjam";

                cbxNp.DataSource = peminjamTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
        private void Kode_film()
        {
            try
            {
                koneksi.Open();

                string str = "SELECT kode_film FROM DVDfilm";
                command = new SqlCommand(str, koneksi);
                DataTable nomorTable = new DataTable();

                adapter = new SqlDataAdapter(command);
                adapter.Fill(nomorTable);

                cbxKf.DisplayMember = "kode_film";
                cbxKf.ValueMember = "kode_film";

                cbxKf.DataSource = nomorTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
    }
}
