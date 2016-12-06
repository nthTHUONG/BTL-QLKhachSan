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
    public partial class FormPhong : Form
    {
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            MessageBox.Show(" hiển thị tình trạng phòng, csdl cơ sở vật chất của tất cả các phòng");
        }

        private void dataGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(" hiển thị csdl cơ sở vật chất của tất cả các phòng");
        }
    }
}
