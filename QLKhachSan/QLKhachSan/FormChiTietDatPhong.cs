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
    public partial class FormChiTietDatPhong : Form
    {
        public FormChiTietDatPhong()
        {
            InitializeComponent();
        }

        private void FormChiTietDatPhong_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hiển thi chi tiết thông tin phòng đã được đặt, cho phép cập nhật,đặt thêm phòng");
        }
    }
}
