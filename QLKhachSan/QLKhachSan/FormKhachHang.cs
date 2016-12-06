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

namespace QLKhachSan
{
    public partial class FormKhachHang : Form
    {
        string cnStr = @"server = .\SQLEXPRESS; database = QLKhachSan; integrated security = true;";
        SqlConnection cnn;
        List<KhachHang> lst = new List<KhachHang>();
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void Connection()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Open)
                {
                    cnn.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void Disconnection()
        {
            try
            {
                if (cnn != null && cnn.State != ConnectionState.Closed)
                {
                    cnn.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void LoadData()
        {
            string sql = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(sql, cnn);  //sql + cnStr de ket noi du lieu
            SqlDataReader dr = cmd.ExecuteReader();
            lst.Clear();
            while (dr.Read() == true)
            {
                KhachHang kh = new KhachHang();
                //kh.IDKhachHang = dr.GetString(0);
                kh.IDKhachHang = dr["IDKhachHang"].ToString();
                kh.Ho = dr["Ho"].ToString();
                kh.Ten = dr["Ten"].ToString();
                kh.GioiTinh = dr["GioiTinh"].ToString();
                kh.DiaChi = dr["DiaChi"].ToString();
                kh.SDT = dr["SDT"].ToString();
                kh.Email = dr["Email"].ToString();
                kh.QuocTich = dr["QuocTich"].ToString();
                lst.Add(kh);
            }
            cmd.Dispose();  //giai phong bien cmd
            dr.Close();
            if (dataGV.DataSource != null)
            {
                dataGV.DataSource = null;
                dataGV.DataSource = lst;
            }
            dataGV.DataSource = lst;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(cnStr);
            try
            {
                Connection();
                LoadData();
                //dataGV_CellClick(sender, );
                Disconnection();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void Init()
        {
            txtIDKhachHang.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            txtQuocTich.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                string sql = "insert into KhachHang values('" + txtIDKhachHang.Text + "', N'" + txtHo.Text + "', N'" + txtTen.Text + "', N'"
                    + txtGioiTinh.Text + "', N'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "', N'" + txtQuocTich.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã thêm thành công!");
                Disconnection();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                string sql = "DELETE FROM KhachHang WHERE IDKhachHang = N'" + txtIDKhachHang.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã xóa thành công!");
                Disconnection();
                Init();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
                string sql = "UPDATE KhachHang SET Ho =  N'" + txtHo.Text + "', Ten = N'" + txtTen.Text
                    + "', GioiTinh = N'" + txtGioiTinh.Text + "', DiaChi = N'" + txtDiaChi.Text
                    + "', SDT = N'" + txtSDT.Text + "', Email = N'" + txtEmail.Text + "', QuocTich = N'"
                    + txtQuocTich.Text + "' WHERE IDKhachHang = N'" + txtIDKhachHang.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LoadData();
                MessageBox.Show("Đã cập nhật thành công!");
                Disconnection();
                Init();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                // throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            dataGV.CurrentCell = null;
            if (txtTimKiem == null)
            {
                for (int i = 0; i < dataGV.RowCount; i++)
                {
                    dataGV.Rows[i].Visible = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGV.RowCount; i++)
                {
                    if (dataGV.Rows[i].Cells["IDKhachHang"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || (dataGV.Rows[i].Cells["Ho"].Value.ToString() + " " + dataGV.Rows[i].Cells["Ten"].Value.ToString()).ToLower().Contains(txtTimKiem.Text.ToLower()) == true
                        || dataGV.Rows[i].Cells["SDT"].Value.ToString().ToLower().Contains(txtTimKiem.Text.ToLower()) == true)
                    {
                        dataGV.Rows[i].Visible = true;
                    }
                    else
                    {
                        dataGV.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGV.Rows[e.RowIndex];
                txtIDKhachHang.Text = row.Cells[0].Value.ToString();
                txtHo.Text = row.Cells[1].Value.ToString();
                txtTen.Text = row.Cells[2].Value.ToString();
                txtGioiTinh.Text = row.Cells[3].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtSDT.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtQuocTich.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
