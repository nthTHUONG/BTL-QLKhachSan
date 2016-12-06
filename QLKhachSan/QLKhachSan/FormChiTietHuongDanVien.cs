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
    public partial class FormChiTietHuongDanVien : Form
    {
        public FormChiTietHuongDanVien()
        {
            InitializeComponent();
        }

        private void FormChiTietHuongDanVien_Load(object sender, EventArgs e)
        {
            MessageBox.Show("tìm kiếm thông tin hướng dẫn viên, cho phép thêm ,cập nhật");
        }
    }
}
