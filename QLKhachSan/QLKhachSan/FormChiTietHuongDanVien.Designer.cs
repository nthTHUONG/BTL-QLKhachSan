namespace QLKhachSan
{
    partial class FormChiTietHuongDanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.btReset = new System.Windows.Forms.Button();
            this.btCapNhat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtTenHDV = new System.Windows.Forms.TextBox();
            this.txtMaHDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGV.Location = new System.Drawing.Point(387, 0);
            this.dataGV.Name = "dataGV";
            this.dataGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV.Size = new System.Drawing.Size(461, 403);
            this.dataGV.TabIndex = 28;
            // 
            // btReset
            // 
            this.btReset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btReset.BackColor = System.Drawing.Color.IndianRed;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(264, 230);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(112, 38);
            this.btReset.TabIndex = 25;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            // 
            // btCapNhat
            // 
            this.btCapNhat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCapNhat.BackColor = System.Drawing.Color.IndianRed;
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.Location = new System.Drawing.Point(151, 230);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(112, 38);
            this.btCapNhat.TabIndex = 26;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.UseVisualStyleBackColor = false;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btThem.BackColor = System.Drawing.Color.IndianRed;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Location = new System.Drawing.Point(39, 230);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(112, 38);
            this.btThem.TabIndex = 27;
            this.btThem.Text = "Thêm HDV";
            this.btThem.UseVisualStyleBackColor = false;
            // 
            // txtTenHDV
            // 
            this.txtTenHDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenHDV.Location = new System.Drawing.Point(84, 74);
            this.txtTenHDV.Multiline = true;
            this.txtTenHDV.Name = "txtTenHDV";
            this.txtTenHDV.Size = new System.Drawing.Size(287, 27);
            this.txtTenHDV.TabIndex = 22;
            // 
            // txtMaHDV
            // 
            this.txtMaHDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaHDV.Location = new System.Drawing.Point(84, 33);
            this.txtMaHDV.Multiline = true;
            this.txtMaHDV.Name = "txtMaHDV";
            this.txtMaHDV.Size = new System.Drawing.Size(287, 27);
            this.txtMaHDV.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên HDV";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã HDV";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 18);
            this.label8.TabIndex = 42;
            this.label8.Text = "Tìm Kiếm";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(93, 154);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(277, 26);
            this.txtTimKiem.TabIndex = 41;
            // 
            // FormChiTietHuongDanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(848, 403);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btCapNhat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtTenHDV);
            this.Controls.Add(this.txtMaHDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormChiTietHuongDanVien";
            this.Text = "Hướng dẫn viên";
            this.Load += new System.EventHandler(this.FormChiTietHuongDanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btCapNhat;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtTenHDV;
        private System.Windows.Forms.TextBox txtMaHDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}