using Npgsql;
using System.Data;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsiAnto";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                dgvData.DataSource = null;
                sql = "select * from karyawan k join departemen d USING(id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Data pilih baris yang ingin dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = @"select * from st_update(:_id_karyawan, :_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", TbKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", convertDepToInt(TbDep.Text));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diedit", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    TbKaryawan.Text = null;
                    r = null;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void InserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from st_insert(:_nama, :_id_dep)";
                cmd = new NpgsqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("_nama", TbKaryawan.Text);
                cmd.Parameters.AddWithValue("_id_dep", convertDepToInt(TbDep.Text));
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil diinput", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    TbKaryawan.Text = null;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if ( r == null)
            {
                MessageBox.Show("Data pilih baris yang ingin dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Yakin ingin menghapus data " + r.Cells["nama"].Value.ToString() + "?", "Hapus Data Terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

            try
            {
                conn.Open();
                sql = @"select * from st_delete(:_id_karyawan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id_karyawan", r.Cells["id_karyawan"].Value.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data karyawan berhasil dihapus", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    LoadData();
                    TbKaryawan.Text = null;
                    r = null;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error: " + Ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            { 
                r = dgvData.Rows[e.RowIndex];
                TbKaryawan.Text = r.Cells["nama"].Value.ToString();
                TbDep.Text = r.Cells["nama_dep"].Value.ToString();
            }
        }

        private void TbDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static int convertDepToInt(string dep)
        {
            switch (dep) {
                case "HR":
                    return 1;
                case "ENG":
                    return 2;
                case "DEV":
                    return 3;
                case "PM":
                    return 4;
                case "FIN":
                    return 5;
            }
            return 1;
        }



    }
}