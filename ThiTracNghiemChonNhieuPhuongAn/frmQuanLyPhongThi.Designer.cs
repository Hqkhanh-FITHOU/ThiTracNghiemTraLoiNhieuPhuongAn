namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmQuanLyPhongThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyPhongThi));
            this.tabDanhSachThi = new System.Windows.Forms.TabControl();
            this.tabThongSoPhongThi = new System.Windows.Forms.TabPage();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.tblMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ThiTracNghiemDataSet = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoaPhongThi = new System.Windows.Forms.Button();
            this.btnSuaPhongThi = new System.Windows.Forms.Button();
            this.chkKhoaPhongThi = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtThoiGianTao = new System.Windows.Forms.DateTimePicker();
            this.txtTenPhongThi = new System.Windows.Forms.TextBox();
            this.txtMaPhongThi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnBaocaoDanhsachThi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dvDanhSachGhiDanh = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvDanhSachChuaGhiDanh = new System.Windows.Forms.DataGridView();
            this.sTaikhoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGhiDanh = new System.Windows.Forms.Button();
            this.btnBoGhiDanh = new System.Windows.Forms.Button();
            this.listPhongThi = new System.Windows.Forms.ListBox();
            this.tblPhongThiTableAdapter = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSetTableAdapters.tblPhongThiTableAdapter();
            this.btnThemPhongThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPhongThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMonHocTableAdapter = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSetTableAdapters.tblMonHocTableAdapter();
            this.tabDanhSachThi.SuspendLayout();
            this.tabThongSoPhongThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhSachGhiDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhSachChuaGhiDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongThiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDanhSachThi
            // 
            this.tabDanhSachThi.Controls.Add(this.tabThongSoPhongThi);
            this.tabDanhSachThi.Controls.Add(this.tabPage2);
            this.tabDanhSachThi.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabDanhSachThi.Location = new System.Drawing.Point(128, 0);
            this.tabDanhSachThi.Name = "tabDanhSachThi";
            this.tabDanhSachThi.SelectedIndex = 0;
            this.tabDanhSachThi.Size = new System.Drawing.Size(638, 506);
            this.tabDanhSachThi.TabIndex = 1;
            // 
            // tabThongSoPhongThi
            // 
            this.tabThongSoPhongThi.AutoScroll = true;
            this.tabThongSoPhongThi.BackColor = System.Drawing.Color.AliceBlue;
            this.tabThongSoPhongThi.Controls.Add(this.cbMon);
            this.tabThongSoPhongThi.Controls.Add(this.label8);
            this.tabThongSoPhongThi.Controls.Add(this.btnXoaPhongThi);
            this.tabThongSoPhongThi.Controls.Add(this.btnSuaPhongThi);
            this.tabThongSoPhongThi.Controls.Add(this.chkKhoaPhongThi);
            this.tabThongSoPhongThi.Controls.Add(this.label6);
            this.tabThongSoPhongThi.Controls.Add(this.dtThoiGianTao);
            this.tabThongSoPhongThi.Controls.Add(this.txtTenPhongThi);
            this.tabThongSoPhongThi.Controls.Add(this.txtMaPhongThi);
            this.tabThongSoPhongThi.Controls.Add(this.label4);
            this.tabThongSoPhongThi.Controls.Add(this.label3);
            this.tabThongSoPhongThi.Controls.Add(this.label2);
            this.tabThongSoPhongThi.Location = new System.Drawing.Point(4, 22);
            this.tabThongSoPhongThi.Name = "tabThongSoPhongThi";
            this.tabThongSoPhongThi.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongSoPhongThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabThongSoPhongThi.Size = new System.Drawing.Size(630, 480);
            this.tabThongSoPhongThi.TabIndex = 0;
            this.tabThongSoPhongThi.Text = "Thông số phòng thi";
            // 
            // cbMon
            // 
            this.cbMon.DataSource = this.tblMonHocBindingSource;
            this.cbMon.DisplayMember = "sTenmonhoc";
            this.cbMon.Enabled = false;
            this.cbMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(221, 236);
            this.cbMon.Name = "cbMon";
            this.cbMon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbMon.Size = new System.Drawing.Size(154, 26);
            this.cbMon.TabIndex = 14;
            this.cbMon.ValueMember = "PK_iMonID";
            // 
            // tblMonHocBindingSource
            // 
            this.tblMonHocBindingSource.DataMember = "tblMonHoc";
            this.tblMonHocBindingSource.DataSource = this.db_ThiTracNghiemDataSet;
            // 
            // db_ThiTracNghiemDataSet
            // 
            this.db_ThiTracNghiemDataSet.DataSetName = "db_ThiTracNghiemDataSet";
            this.db_ThiTracNghiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(63, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Môn thi";
            // 
            // btnXoaPhongThi
            // 
            this.btnXoaPhongThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaPhongThi.Location = new System.Drawing.Point(257, 291);
            this.btnXoaPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaPhongThi.Name = "btnXoaPhongThi";
            this.btnXoaPhongThi.Size = new System.Drawing.Size(143, 46);
            this.btnXoaPhongThi.TabIndex = 12;
            this.btnXoaPhongThi.Text = "Xóa phòng thi";
            this.btnXoaPhongThi.UseVisualStyleBackColor = true;
            this.btnXoaPhongThi.Click += new System.EventHandler(this.btnXoaPhongThi_Click);
            // 
            // btnSuaPhongThi
            // 
            this.btnSuaPhongThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuaPhongThi.Location = new System.Drawing.Point(424, 291);
            this.btnSuaPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaPhongThi.Name = "btnSuaPhongThi";
            this.btnSuaPhongThi.Size = new System.Drawing.Size(128, 46);
            this.btnSuaPhongThi.TabIndex = 11;
            this.btnSuaPhongThi.Text = "Sửa";
            this.btnSuaPhongThi.UseVisualStyleBackColor = true;
            this.btnSuaPhongThi.Click += new System.EventHandler(this.btnSuaPhongThi_Click);
            // 
            // chkKhoaPhongThi
            // 
            this.chkKhoaPhongThi.AutoSize = true;
            this.chkKhoaPhongThi.Enabled = false;
            this.chkKhoaPhongThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkKhoaPhongThi.Location = new System.Drawing.Point(221, 185);
            this.chkKhoaPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.chkKhoaPhongThi.Name = "chkKhoaPhongThi";
            this.chkKhoaPhongThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkKhoaPhongThi.Size = new System.Drawing.Size(154, 28);
            this.chkKhoaPhongThi.TabIndex = 9;
            this.chkKhoaPhongThi.Text = "khóa phòng thi";
            this.chkKhoaPhongThi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(63, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Trạng thái";
            // 
            // dtThoiGianTao
            // 
            this.dtThoiGianTao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtThoiGianTao.Enabled = false;
            this.dtThoiGianTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtThoiGianTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiGianTao.Location = new System.Drawing.Point(221, 136);
            this.dtThoiGianTao.Margin = new System.Windows.Forms.Padding(2);
            this.dtThoiGianTao.Name = "dtThoiGianTao";
            this.dtThoiGianTao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtThoiGianTao.Size = new System.Drawing.Size(339, 29);
            this.dtThoiGianTao.TabIndex = 7;
            // 
            // txtTenPhongThi
            // 
            this.txtTenPhongThi.Enabled = false;
            this.txtTenPhongThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhongThi.Location = new System.Drawing.Point(221, 86);
            this.txtTenPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPhongThi.Name = "txtTenPhongThi";
            this.txtTenPhongThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenPhongThi.Size = new System.Drawing.Size(339, 29);
            this.txtTenPhongThi.TabIndex = 5;
            // 
            // txtMaPhongThi
            // 
            this.txtMaPhongThi.Enabled = false;
            this.txtMaPhongThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhongThi.Location = new System.Drawing.Point(221, 38);
            this.txtMaPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhongThi.Name = "txtMaPhongThi";
            this.txtMaPhongThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMaPhongThi.Size = new System.Drawing.Size(339, 29);
            this.txtMaPhongThi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(63, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thời gian tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(63, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên phòng thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(63, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phòng thi";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.btnBaocaoDanhsachThi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dvDanhSachGhiDanh);
            this.tabPage2.Controls.Add(this.dvDanhSachChuaGhiDanh);
            this.tabPage2.Controls.Add(this.btnGhiDanh);
            this.tabPage2.Controls.Add(this.btnBoGhiDanh);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(630, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách thí sinh";
            // 
            // btnBaocaoDanhsachThi
            // 
            this.btnBaocaoDanhsachThi.Location = new System.Drawing.Point(11, 443);
            this.btnBaocaoDanhsachThi.Name = "btnBaocaoDanhsachThi";
            this.btnBaocaoDanhsachThi.Size = new System.Drawing.Size(141, 23);
            this.btnBaocaoDanhsachThi.TabIndex = 9;
            this.btnBaocaoDanhsachThi.Text = "Báo cáo danh sách thi";
            this.btnBaocaoDanhsachThi.UseVisualStyleBackColor = true;
            this.btnBaocaoDanhsachThi.Click += new System.EventHandler(this.btnBaocaoDanhsachThi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Danh sách chưa ghi danh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Danh sách đã ghi danh";
            // 
            // dvDanhSachGhiDanh
            // 
            this.dvDanhSachGhiDanh.AllowUserToDeleteRows = false;
            this.dvDanhSachGhiDanh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvDanhSachGhiDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDanhSachGhiDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dvDanhSachGhiDanh.Location = new System.Drawing.Point(12, 34);
            this.dvDanhSachGhiDanh.Name = "dvDanhSachGhiDanh";
            this.dvDanhSachGhiDanh.ReadOnly = true;
            this.dvDanhSachGhiDanh.RowHeadersWidth = 62;
            this.dvDanhSachGhiDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDanhSachGhiDanh.Size = new System.Drawing.Size(273, 402);
            this.dvDanhSachGhiDanh.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PK_sTaikhoanID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã tài khoản";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "sHoten";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dvDanhSachChuaGhiDanh
            // 
            this.dvDanhSachChuaGhiDanh.AllowUserToDeleteRows = false;
            this.dvDanhSachChuaGhiDanh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dvDanhSachChuaGhiDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDanhSachChuaGhiDanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTaikhoanID,
            this.sHoten});
            this.dvDanhSachChuaGhiDanh.Location = new System.Drawing.Point(349, 34);
            this.dvDanhSachChuaGhiDanh.Name = "dvDanhSachChuaGhiDanh";
            this.dvDanhSachChuaGhiDanh.ReadOnly = true;
            this.dvDanhSachChuaGhiDanh.RowHeadersWidth = 62;
            this.dvDanhSachChuaGhiDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDanhSachChuaGhiDanh.Size = new System.Drawing.Size(273, 402);
            this.dvDanhSachChuaGhiDanh.TabIndex = 5;
            this.dvDanhSachChuaGhiDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvDanhSachChuaGhiDanh_CellClick);
            // 
            // sTaikhoanID
            // 
            this.sTaikhoanID.DataPropertyName = "PK_sTaikhoanID";
            this.sTaikhoanID.HeaderText = "Mã tài khoản";
            this.sTaikhoanID.MinimumWidth = 8;
            this.sTaikhoanID.Name = "sTaikhoanID";
            this.sTaikhoanID.ReadOnly = true;
            this.sTaikhoanID.Width = 150;
            // 
            // sHoten
            // 
            this.sHoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sHoten.DataPropertyName = "sHoten";
            this.sHoten.HeaderText = "Họ tên";
            this.sHoten.MinimumWidth = 8;
            this.sHoten.Name = "sHoten";
            this.sHoten.ReadOnly = true;
            // 
            // btnGhiDanh
            // 
            this.btnGhiDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGhiDanh.Location = new System.Drawing.Point(295, 181);
            this.btnGhiDanh.Name = "btnGhiDanh";
            this.btnGhiDanh.Size = new System.Drawing.Size(45, 30);
            this.btnGhiDanh.TabIndex = 3;
            this.btnGhiDanh.Text = "< <";
            this.btnGhiDanh.UseVisualStyleBackColor = true;
            this.btnGhiDanh.Click += new System.EventHandler(this.btnGhiDanh_Click);
            // 
            // btnBoGhiDanh
            // 
            this.btnBoGhiDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBoGhiDanh.Location = new System.Drawing.Point(295, 118);
            this.btnBoGhiDanh.Name = "btnBoGhiDanh";
            this.btnBoGhiDanh.Size = new System.Drawing.Size(45, 30);
            this.btnBoGhiDanh.TabIndex = 2;
            this.btnBoGhiDanh.Text = "> >";
            this.btnBoGhiDanh.UseVisualStyleBackColor = true;
            this.btnBoGhiDanh.Click += new System.EventHandler(this.btnBoGhiDanh_Click);
            // 
            // listPhongThi
            // 
            this.listPhongThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listPhongThi.FormattingEnabled = true;
            this.listPhongThi.Location = new System.Drawing.Point(0, 56);
            this.listPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.listPhongThi.Name = "listPhongThi";
            this.listPhongThi.Size = new System.Drawing.Size(127, 433);
            this.listPhongThi.TabIndex = 0;
            this.listPhongThi.SelectedIndexChanged += new System.EventHandler(this.listPhongThi_SelectedIndexChanged);
            // 
            // tblPhongThiTableAdapter
            // 
            this.tblPhongThiTableAdapter.ClearBeforeFill = true;
            // 
            // btnThemPhongThi
            // 
            this.btnThemPhongThi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnThemPhongThi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemPhongThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThemPhongThi.Location = new System.Drawing.Point(0, 0);
            this.btnThemPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhongThi.Name = "btnThemPhongThi";
            this.btnThemPhongThi.Size = new System.Drawing.Size(128, 27);
            this.btnThemPhongThi.TabIndex = 2;
            this.btnThemPhongThi.Text = "Thêm phòng thi";
            this.btnThemPhongThi.UseVisualStyleBackColor = false;
            this.btnThemPhongThi.Click += new System.EventHandler(this.btnThemPhongThi_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách phòng thi";
            // 
            // tblPhongThiBindingSource
            // 
            this.tblPhongThiBindingSource.DataMember = "tblPhongThi";
            this.tblPhongThiBindingSource.DataSource = this.db_ThiTracNghiemDataSet;
            // 
            // tblMonHocTableAdapter
            // 
            this.tblMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // frmQuanLyPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(766, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemPhongThi);
            this.Controls.Add(this.listPhongThi);
            this.Controls.Add(this.tabDanhSachThi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyPhongThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLyPhongThi";
            this.Load += new System.EventHandler(this.frmQuanLyPhongThi_Load);
            this.tabDanhSachThi.ResumeLayout(false);
            this.tabThongSoPhongThi.ResumeLayout(false);
            this.tabThongSoPhongThi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhSachGhiDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhSachChuaGhiDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongThiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabDanhSachThi;
        private System.Windows.Forms.TabPage tabThongSoPhongThi;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listPhongThi;
        private db_ThiTracNghiemDataSet db_ThiTracNghiemDataSet;
        private db_ThiTracNghiemDataSetTableAdapters.tblPhongThiTableAdapter tblPhongThiTableAdapter;
        private System.Windows.Forms.Button btnThemPhongThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtThoiGianTao;
        private System.Windows.Forms.TextBox txtTenPhongThi;
        private System.Windows.Forms.TextBox txtMaPhongThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaPhongThi;
        private System.Windows.Forms.CheckBox chkKhoaPhongThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoaPhongThi;
        private System.Windows.Forms.Button btnGhiDanh;
        private System.Windows.Forms.Button btnBoGhiDanh;
        private System.Windows.Forms.BindingSource tblPhongThiBindingSource;
        private System.Windows.Forms.DataGridView dvDanhSachChuaGhiDanh;
        private System.Windows.Forms.DataGridView dvDanhSachGhiDanh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTaikhoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource tblMonHocBindingSource;
        private db_ThiTracNghiemDataSetTableAdapters.tblMonHocTableAdapter tblMonHocTableAdapter;
        private System.Windows.Forms.Button btnBaocaoDanhsachThi;
    }
}