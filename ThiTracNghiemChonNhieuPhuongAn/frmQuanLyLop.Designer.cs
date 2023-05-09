namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmQuanLyLop
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
            this.btnThemLop = new System.Windows.Forms.Button();
            this.listLop = new System.Windows.Forms.ListBox();
            this.txt1 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvThanhVienLop_1 = new System.Windows.Forms.DataGridView();
            this.sTaikhoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sChucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXoaLop = new System.Windows.Forms.Button();
            this.dvDaGhiDanh = new System.Windows.Forms.DataGridView();
            this.dvChuaGhiDanh = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBoGhiDanh = new System.Windows.Forms.Button();
            this.btnGhiDanh = new System.Windows.Forms.Button();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.sMaTaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hovaten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvThanhVienLop_1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDaGhiDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvChuaGhiDanh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemLop
            // 
            this.btnThemLop.Location = new System.Drawing.Point(20, 20);
            this.btnThemLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(180, 54);
            this.btnThemLop.TabIndex = 0;
            this.btnThemLop.Text = "Thêm lớp";
            this.btnThemLop.UseVisualStyleBackColor = true;
            this.btnThemLop.Click += new System.EventHandler(this.btnThemLop_Click);
            // 
            // listLop
            // 
            this.listLop.FormattingEnabled = true;
            this.listLop.ItemHeight = 20;
            this.listLop.Location = new System.Drawing.Point(20, 83);
            this.listLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listLop.Name = "listLop";
            this.listLop.Size = new System.Drawing.Size(178, 724);
            this.listLop.TabIndex = 1;
            this.listLop.SelectedIndexChanged += new System.EventHandler(this.listLop_SelectedIndexChanged);
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt1.Location = new System.Drawing.Point(225, 20);
            this.txt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(77, 25);
            this.txt1.TabIndex = 2;
            this.txt1.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            this.txtMaLop.AutoSize = true;
            this.txtMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaLop.Location = new System.Drawing.Point(303, 22);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 25);
            this.txtMaLop.TabIndex = 3;
            this.txtMaLop.Text = "txtTenLop";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(224, 62);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(908, 709);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dvThanhVienLop_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(900, 676);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dvThanhVienLop_1
            // 
            this.dvThanhVienLop_1.AllowUserToDeleteRows = false;
            this.dvThanhVienLop_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvThanhVienLop_1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvThanhVienLop_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThanhVienLop_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTaikhoanID,
            this.sHoten,
            this.dNgaysinh,
            this.bGioitinh,
            this.sChucvu});
            this.dvThanhVienLop_1.Location = new System.Drawing.Point(9, 9);
            this.dvThanhVienLop_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvThanhVienLop_1.MultiSelect = false;
            this.dvThanhVienLop_1.Name = "dvThanhVienLop_1";
            this.dvThanhVienLop_1.ReadOnly = true;
            this.dvThanhVienLop_1.RowHeadersVisible = false;
            this.dvThanhVienLop_1.RowHeadersWidth = 62;
            this.dvThanhVienLop_1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvThanhVienLop_1.Size = new System.Drawing.Size(878, 651);
            this.dvThanhVienLop_1.TabIndex = 0;
            // 
            // sTaikhoanID
            // 
            this.sTaikhoanID.DataPropertyName = "sTaikhoanID";
            this.sTaikhoanID.HeaderText = "Mã tài khoản";
            this.sTaikhoanID.MinimumWidth = 8;
            this.sTaikhoanID.Name = "sTaikhoanID";
            this.sTaikhoanID.ReadOnly = true;
            // 
            // sHoten
            // 
            this.sHoten.DataPropertyName = "sHoten";
            this.sHoten.HeaderText = "Họ tên";
            this.sHoten.MinimumWidth = 8;
            this.sHoten.Name = "sHoten";
            this.sHoten.ReadOnly = true;
            // 
            // dNgaysinh
            // 
            this.dNgaysinh.DataPropertyName = "dNgaysinh";
            this.dNgaysinh.HeaderText = "Ngày sinh";
            this.dNgaysinh.MinimumWidth = 8;
            this.dNgaysinh.Name = "dNgaysinh";
            this.dNgaysinh.ReadOnly = true;
            // 
            // bGioitinh
            // 
            this.bGioitinh.DataPropertyName = "bGioitinh";
            this.bGioitinh.HeaderText = "Giới tính";
            this.bGioitinh.MinimumWidth = 8;
            this.bGioitinh.Name = "bGioitinh";
            this.bGioitinh.ReadOnly = true;
            // 
            // sChucvu
            // 
            this.sChucvu.DataPropertyName = "sChucvu";
            this.sChucvu.HeaderText = "Chức vụ";
            this.sChucvu.MinimumWidth = 8;
            this.sChucvu.Name = "sChucvu";
            this.sChucvu.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbChucVu);
            this.tabPage2.Controls.Add(this.btnGhiDanh);
            this.tabPage2.Controls.Add(this.btnBoGhiDanh);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(900, 676);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý thành viên lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXoaLop
            // 
            this.btnXoaLop.Location = new System.Drawing.Point(930, 774);
            this.btnXoaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaLop.Name = "btnXoaLop";
            this.btnXoaLop.Size = new System.Drawing.Size(195, 48);
            this.btnXoaLop.TabIndex = 5;
            this.btnXoaLop.Text = "Xóa lớp";
            this.btnXoaLop.UseVisualStyleBackColor = true;
            this.btnXoaLop.Click += new System.EventHandler(this.btnXoaLop_Click);
            // 
            // dvDaGhiDanh
            // 
            this.dvDaGhiDanh.AllowUserToDeleteRows = false;
            this.dvDaGhiDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvDaGhiDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDaGhiDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaTaikhoan,
            this.hoten});
            this.dvDaGhiDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDaGhiDanh.Location = new System.Drawing.Point(3, 22);
            this.dvDaGhiDanh.Name = "dvDaGhiDanh";
            this.dvDaGhiDanh.ReadOnly = true;
            this.dvDaGhiDanh.RowHeadersVisible = false;
            this.dvDaGhiDanh.RowHeadersWidth = 62;
            this.dvDaGhiDanh.RowTemplate.Height = 28;
            this.dvDaGhiDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDaGhiDanh.Size = new System.Drawing.Size(339, 635);
            this.dvDaGhiDanh.TabIndex = 0;
            // 
            // dvChuaGhiDanh
            // 
            this.dvChuaGhiDanh.AllowUserToDeleteRows = false;
            this.dvChuaGhiDanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvChuaGhiDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvChuaGhiDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTaikhoan,
            this.Hovaten});
            this.dvChuaGhiDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvChuaGhiDanh.Location = new System.Drawing.Point(3, 22);
            this.dvChuaGhiDanh.Name = "dvChuaGhiDanh";
            this.dvChuaGhiDanh.ReadOnly = true;
            this.dvChuaGhiDanh.RowHeadersVisible = false;
            this.dvChuaGhiDanh.RowHeadersWidth = 62;
            this.dvChuaGhiDanh.RowTemplate.Height = 28;
            this.dvChuaGhiDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvChuaGhiDanh.Size = new System.Drawing.Size(353, 632);
            this.dvChuaGhiDanh.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvDaGhiDanh);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 660);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đã ghi danh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dvChuaGhiDanh);
            this.groupBox2.Location = new System.Drawing.Point(534, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 657);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chưa ghi danh";
            // 
            // btnBoGhiDanh
            // 
            this.btnBoGhiDanh.Location = new System.Drawing.Point(371, 227);
            this.btnBoGhiDanh.Name = "btnBoGhiDanh";
            this.btnBoGhiDanh.Size = new System.Drawing.Size(146, 42);
            this.btnBoGhiDanh.TabIndex = 4;
            this.btnBoGhiDanh.Text = "> >";
            this.btnBoGhiDanh.UseVisualStyleBackColor = true;
            this.btnBoGhiDanh.Click += new System.EventHandler(this.btnBoGhiDanh_Click);
            // 
            // btnGhiDanh
            // 
            this.btnGhiDanh.Location = new System.Drawing.Point(371, 374);
            this.btnGhiDanh.Name = "btnGhiDanh";
            this.btnGhiDanh.Size = new System.Drawing.Size(146, 42);
            this.btnGhiDanh.TabIndex = 5;
            this.btnGhiDanh.Text = "< <";
            this.btnGhiDanh.UseVisualStyleBackColor = true;
            this.btnGhiDanh.Click += new System.EventHandler(this.btnGhiDanh_Click);
            // 
            // cbChucVu
            // 
            this.cbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Thành viên bình thường",
            "Giáo viên"});
            this.cbChucVu.Location = new System.Drawing.Point(371, 305);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(146, 33);
            this.cbChucVu.TabIndex = 6;
            // 
            // sMaTaikhoan
            // 
            this.sMaTaikhoan.DataPropertyName = "Pk_sTaikhoanID";
            this.sMaTaikhoan.FillWeight = 79.54546F;
            this.sMaTaikhoan.HeaderText = "Mã tài khoản";
            this.sMaTaikhoan.MinimumWidth = 8;
            this.sMaTaikhoan.Name = "sMaTaikhoan";
            this.sMaTaikhoan.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "sHoten";
            this.hoten.FillWeight = 120.4545F;
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // MaTaikhoan
            // 
            this.MaTaikhoan.DataPropertyName = "Pk_sTaikhoanID";
            this.MaTaikhoan.FillWeight = 79F;
            this.MaTaikhoan.HeaderText = "Mã tài khoản";
            this.MaTaikhoan.MinimumWidth = 8;
            this.MaTaikhoan.Name = "MaTaikhoan";
            this.MaTaikhoan.ReadOnly = true;
            // 
            // Hovaten
            // 
            this.Hovaten.DataPropertyName = "sHoten";
            this.Hovaten.FillWeight = 120F;
            this.Hovaten.HeaderText = "Họ tên";
            this.Hovaten.MinimumWidth = 8;
            this.Hovaten.Name = "Hovaten";
            this.Hovaten.ReadOnly = true;
            // 
            // frmQuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1149, 877);
            this.Controls.Add(this.btnXoaLop);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.listLop);
            this.Controls.Add(this.btnThemLop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyLop";
            this.Text = "Quản lý lớp";
            this.Load += new System.EventHandler(this.frmQuanLyLop_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvThanhVienLop_1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDaGhiDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvChuaGhiDanh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemLop;
        private System.Windows.Forms.ListBox listLop;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label txtMaLop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnXoaLop;
        private System.Windows.Forms.DataGridView dvThanhVienLop_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTaikhoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn bGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sChucvu;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Button btnGhiDanh;
        private System.Windows.Forms.Button btnBoGhiDanh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvChuaGhiDanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvDaGhiDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hovaten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
    }
}