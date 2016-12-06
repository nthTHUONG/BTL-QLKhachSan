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
    public partial class FormChiTietXe : Form
    {
        public FormChiTietXe()
        {
            InitializeComponent();
        }

        private void FormChiTietXe_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất bảng chi tiết thuê xe, cho phép cập nhật dữ liệu trực tiếp trên form, trạng thái của từng xe hiển thị qua lable màu tương ứng: xang,đỏ.");
        }
    }
}
