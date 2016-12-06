using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class FormChiTietThucPham : Form
    {
        public FormChiTietThucPham()
        {
            InitializeComponent();
        }

        private void FormChiTietThucPham_Load(object sender, EventArgs e)
        {
            MessageBox.Show("thêm vào danh sách thực phẩm: mã, tên và miêu tả .Cho phép cập nhật,xóa dữ liệu");
        }
    }
}
