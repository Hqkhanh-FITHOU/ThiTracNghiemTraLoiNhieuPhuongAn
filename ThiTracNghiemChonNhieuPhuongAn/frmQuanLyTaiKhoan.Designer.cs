namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmQuanLyTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.cbQuyenHan = new System.Windows.Forms.ComboBox();
            this.tblQuyenHanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ThiTracNghiemDataSet = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSet();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.dvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.PK_sTaikhoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bGioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sQuyenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblQuyenHanTableAdapter = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSetTableAdapters.tblQuyenHanTableAdapter();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tblTaiKhoanTableAdapter = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSetTableAdapters.tblTaiKhoanTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHuy1 = new System.Windows.Forms.Button();
            this.btnHuySua = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.numTuoi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tblQuyenHanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaiKhoanBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vai trò";
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(159, 40);
            this.txtMaTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.ReadOnly = true;
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(302, 32);
            this.txtMaTaiKhoan.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.Location = new System.Drawing.Point(159, 103);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(302, 32);
            this.txtHoTen.TabIndex = 6;
            // 
            // cbQuyenHan
            // 
            this.cbQuyenHan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblQuyenHanBindingSource, "PK_sQuyenID", true));
            this.cbQuyenHan.Enabled = false;
            this.cbQuyenHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbQuyenHan.FormattingEnabled = true;
            this.cbQuyenHan.Items.AddRange(new object[] {
            "Quản trị",
            "Học viên",
            "Giám thị"});
            this.cbQuyenHan.Location = new System.Drawing.Point(159, 268);
            this.cbQuyenHan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbQuyenHan.Name = "cbQuyenHan";
            this.cbQuyenHan.Size = new System.Drawing.Size(223, 34);
            this.cbQuyenHan.TabIndex = 8;
            this.cbQuyenHan.SelectedIndexChanged += new System.EventHandler(this.cbQuyenHan_SelectedIndexChanged);
            // 
            // tblQuyenHanBindingSource
            // 
            this.tblQuyenHanBindingSource.DataMember = "tblQuyenHan";
            this.tblQuyenHanBindingSource.DataSource = this.db_ThiTracNghiemDataSet;
            // 
            // db_ThiTracNghiemDataSet
            // 
            this.db_ThiTracNghiemDataSet.DataSetName = "db_ThiTracNghiemDataSet";
            this.db_ThiTracNghiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Enabled = false;
            this.radNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNam.Location = new System.Drawing.Point(159, 220);
            this.radNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(84, 30);
            this.radNam.TabIndex = 9;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Enabled = false;
            this.radNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radNu.Location = new System.Drawing.Point(316, 220);
            this.radNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(65, 30);
            this.radNu.TabIndex = 10;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtNgaySinh.Enabled = false;
            this.dtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(159, 158);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(298, 32);
            this.dtNgaySinh.TabIndex = 11;
            // 
            // dvTaiKhoan
            // 
            this.dvTaiKhoan.AllowUserToDeleteRows = false;
            this.dvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_sTaikhoanID,
            this.sHoten,
            this.dNgaysinh,
            this.bGioitinh,
            this.sQuyenID,
            this.sMatkhau});
            this.dvTaiKhoan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dvTaiKhoan.Location = new System.Drawing.Point(82, 546);
            this.dvTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvTaiKhoan.Name = "dvTaiKhoan";
            this.dvTaiKhoan.ReadOnly = true;
            this.dvTaiKhoan.RowHeadersWidth = 62;
            this.dvTaiKhoan.Size = new System.Drawing.Size(958, 582);
            this.dvTaiKhoan.TabIndex = 12;
            this.dvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PK_sTaikhoanID
            // 
            this.PK_sTaikhoanID.DataPropertyName = "PK_sTaikhoanID";
            this.PK_sTaikhoanID.HeaderText = "Mã tài khoản";
            this.PK_sTaikhoanID.MinimumWidth = 8;
            this.PK_sTaikhoanID.Name = "PK_sTaikhoanID";
            this.PK_sTaikhoanID.ReadOnly = true;
            this.PK_sTaikhoanID.Width = 150;
            // 
            // sHoten
            // 
            this.sHoten.DataPropertyName = "sHoten";
            this.sHoten.HeaderText = "Họ tên";
            this.sHoten.MinimumWidth = 8;
            this.sHoten.Name = "sHoten";
            this.sHoten.ReadOnly = true;
            this.sHoten.Width = 150;
            // 
            // dNgaysinh
            // 
            this.dNgaysinh.DataPropertyName = "dNgaysinh";
            this.dNgaysinh.HeaderText = "Ngày sinh";
            this.dNgaysinh.MinimumWidth = 8;
            this.dNgaysinh.Name = "dNgaysinh";
            this.dNgaysinh.ReadOnly = true;
            this.dNgaysinh.Width = 150;
            // 
            // bGioitinh
            // 
            this.bGioitinh.DataPropertyName = "bGioitinh";
            this.bGioitinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGioitinh.HeaderText = "Giới tính";
            this.bGioitinh.MinimumWidth = 8;
            this.bGioitinh.Name = "bGioitinh";
            this.bGioitinh.ReadOnly = true;
            this.bGioitinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bGioitinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bGioitinh.Width = 150;
            // 
            // sQuyenID
            // 
            this.sQuyenID.DataPropertyName = "sQuyenID";
            this.sQuyenID.HeaderText = "Vai trò";
            this.sQuyenID.MinimumWidth = 8;
            this.sQuyenID.Name = "sQuyenID";
            this.sQuyenID.ReadOnly = true;
            this.sQuyenID.Width = 150;
            // 
            // sMatkhau
            // 
            this.sMatkhau.DataPropertyName = "sMatkhau";
            this.sMatkhau.HeaderText = "Mật khẩu";
            this.sMatkhau.MinimumWidth = 8;
            this.sMatkhau.Name = "sMatkhau";
            this.sMatkhau.ReadOnly = true;
            this.sMatkhau.Width = 150;
            // 
            // tblTaiKhoanBindingSource
            // 
            this.tblTaiKhoanBindingSource.DataMember = "tblTaiKhoan";
            this.tblTaiKhoanBindingSource.DataSource = this.db_ThiTracNghiemDataSet;
            // 
            // tblQuyenHanTableAdapter
            // 
            this.tblQuyenHanTableAdapter.ClearBeforeFill = true;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(26, 45);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(273, 57);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(26, 114);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(273, 57);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Bật chỉnh sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(26, 183);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(273, 57);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(26, 252);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(273, 57);
            this.btnTimKiem.TabIndex = 16;
            this.btnTimKiem.Text = "Bật tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tblTaiKhoanTableAdapter
            // 
            this.tblTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numTuoi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.cbQuyenHan);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaTaiKhoan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(82, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(488, 444);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(16, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Enabled = false;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(159, 335);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(298, 32);
            this.txtMatKhau.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.btnHuy1);
            this.groupBox2.Controls.Add(this.btnHuySua);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(656, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(392, 329);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tool";
            // 
            // btnTim
            // 
            this.btnTim.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.search_magnifyng_glass_find_locate_icon_123485;
            this.btnTim.Location = new System.Drawing.Point(309, 252);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(58, 57);
            this.btnTim.TabIndex = 19;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Visible = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnHuy1
            // 
            this.btnHuy1.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.delete_unapprove_discard_remove_x_red_icon_icons_com_55984;
            this.btnHuy1.Location = new System.Drawing.Point(309, 45);
            this.btnHuy1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy1.Name = "btnHuy1";
            this.btnHuy1.Size = new System.Drawing.Size(58, 57);
            this.btnHuy1.TabIndex = 18;
            this.btnHuy1.UseVisualStyleBackColor = true;
            this.btnHuy1.Visible = false;
            this.btnHuy1.Click += new System.EventHandler(this.btnHuy1_Click);
            // 
            // btnHuySua
            // 
            this.btnHuySua.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.delete_unapprove_discard_remove_x_red_icon_icons_com_55984;
            this.btnHuySua.Location = new System.Drawing.Point(309, 114);
            this.btnHuySua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuySua.Name = "btnHuySua";
            this.btnHuySua.Size = new System.Drawing.Size(58, 57);
            this.btnHuySua.TabIndex = 17;
            this.btnHuySua.UseVisualStyleBackColor = true;
            this.btnHuySua.Visible = false;
            this.btnHuySua.Click += new System.EventHandler(this.btnHuySua_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(88, 502);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(99, 35);
            this.btnClearFilter.TabIndex = 19;
            this.btnClearFilter.Text = "Clear filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dvTaiKhoan);
            this.panel1.Controls.Add(this.btnClearFilter);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 1162);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(21, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tuổi";
            this.label7.Visible = false;
            // 
            // numTuoi
            // 
            this.numTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.numTuoi.Location = new System.Drawing.Point(159, 391);
            this.numTuoi.Name = "numTuoi";
            this.numTuoi.Size = new System.Drawing.Size(298, 30);
            this.numTuoi.TabIndex = 15;
            this.numTuoi.Visible = false;
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1158, 1162);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblQuyenHanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTaiKhoanBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTuoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTaiKhoan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox cbQuyenHan;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.DataGridView dvTaiKhoan;
        private db_ThiTracNghiemDataSet db_ThiTracNghiemDataSet;
        private System.Windows.Forms.BindingSource tblQuyenHanBindingSource;
        private db_ThiTracNghiemDataSetTableAdapters.tblQuyenHanTableAdapter tblQuyenHanTableAdapter;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.BindingSource tblTaiKhoanBindingSource;
        private db_ThiTracNghiemDataSetTableAdapters.tblTaiKhoanTableAdapter tblTaiKhoanTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_sTaikhoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNgaysinh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sQuyenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMatkhau;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnHuySua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnHuy1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numTuoi;
        private System.Windows.Forms.Label label7;
    }
}