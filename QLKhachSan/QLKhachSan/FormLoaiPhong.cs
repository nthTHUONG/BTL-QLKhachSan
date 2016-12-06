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
    public partial class FormLoaiPhong : Form
    {
        public FormLoaiPhong()
        {
            InitializeComponent();
        }

        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" hiển thị csdl loại phòng, cho phép tìm kiếm và cập nhật số lượng phòng, giá phòng và tên phòng theo mã loại phòng");
        }
    }
}
