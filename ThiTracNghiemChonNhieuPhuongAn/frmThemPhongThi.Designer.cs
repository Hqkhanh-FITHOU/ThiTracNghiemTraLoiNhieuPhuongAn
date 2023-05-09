namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmThemPhongThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemPhongThi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtThoiGianTaoPhong = new System.Windows.Forms.DateTimePicker();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.chkDongPhongthi = new System.Windows.Forms.CheckBox();
            this.btnHuyThemPhongThi = new System.Windows.Forms.Button();
            this.btnTaoPhongThi = new System.Windows.Forms.Button();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.tblMonHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbThiTracNghiemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ThiTracNghiemDataSet = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.tblMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMonHocTableAdapter = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSetTableAdapters.tblMonHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThiTracNghiemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái";
            // 
            // dtThoiGianTaoPhong
            // 
            this.dtThoiGianTaoPhong.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtThoiGianTaoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtThoiGianTaoPhong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiGianTaoPhong.Location = new System.Drawing.Point(136, 99);
            this.dtThoiGianTaoPhong.Margin = new System.Windows.Forms.Padding(2);
            this.dtThoiGianTaoPhong.Name = "dtThoiGianTaoPhong";
            this.dtThoiGianTaoPhong.Size = new System.Drawing.Size(193, 26);
            this.dtThoiGianTaoPhong.TabIndex = 4;
            this.dtThoiGianTaoPhong.Value = new System.DateTime(2023, 4, 10, 13, 40, 0, 0);
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenPhong.Location = new System.Drawing.Point(136, 62);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(193, 26);
            this.txtTenPhong.TabIndex = 5;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaPhong.Location = new System.Drawing.Point(136, 24);
            this.txtMaPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(193, 26);
            this.txtMaPhong.TabIndex = 6;
            // 
            // chkDongPhongthi
            // 
            this.chkDongPhongthi.AutoSize = true;
            this.chkDongPhongthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkDongPhongthi.Location = new System.Drawing.Point(136, 137);
            this.chkDongPhongthi.Margin = new System.Windows.Forms.Padding(2);
            this.chkDongPhongthi.Name = "chkDongPhongthi";
            this.chkDongPhongthi.Size = new System.Drawing.Size(67, 24);
            this.chkDongPhongthi.TabIndex = 7;
            this.chkDongPhongthi.Text = "Đóng";
            this.chkDongPhongthi.UseVisualStyleBackColor = true;
            // 
            // btnHuyThemPhongThi
            // 
            this.btnHuyThemPhongThi.Location = new System.Drawing.Point(96, 230);
            this.btnHuyThemPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyThemPhongThi.Name = "btnHuyThemPhongThi";
            this.btnHuyThemPhongThi.Size = new System.Drawing.Size(90, 39);
            this.btnHuyThemPhongThi.TabIndex = 8;
            this.btnHuyThemPhongThi.Text = "Hủy";
            this.btnHuyThemPhongThi.UseVisualStyleBackColor = true;
            this.btnHuyThemPhongThi.Click += new System.EventHandler(this.btnHuyThemPhongThi_Click);
            // 
            // btnTaoPhongThi
            // 
            this.btnTaoPhongThi.Location = new System.Drawing.Point(234, 230);
            this.btnTaoPhongThi.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoPhongThi.Name = "btnTaoPhongThi";
            this.btnTaoPhongThi.Size = new System.Drawing.Size(90, 39);
            this.btnTaoPhongThi.TabIndex = 9;
            this.btnTaoPhongThi.Text = "Tạo";
            this.btnTaoPhongThi.UseVisualStyleBackColor = true;
            this.btnTaoPhongThi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTaoPhongThi_MouseClick);
            // 
            // cbMon
            // 
            this.cbMon.DataSource = this.tblMonHocBindingSource1;
            this.cbMon.DisplayMember = "sTenmonhoc";
            this.cbMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(136, 177);
            this.cbMon.Name = "cbMon";
            this.cbMon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbMon.Size = new System.Drawing.Size(188, 26);
            this.cbMon.TabIndex = 16;
            this.cbMon.ValueMember = "PK_iMonID";
            // 
            // tblMonHocBindingSource1
            // 
            this.tblMonHocBindingSource1.DataMember = "tblMonHoc";
            this.tblMonHocBindingSource1.DataSource = this.dbThiTracNghiemDataSetBindingSource;
            // 
            // dbThiTracNghiemDataSetBindingSource
            // 
            this.dbThiTracNghiemDataSetBindingSource.DataSource = this.db_ThiTracNghiemDataSet;
            this.dbThiTracNghiemDataSetBindingSource.Position = 0;
            // 
            // db_ThiTracNghiemDataSet
            // 
            this.db_ThiTracNghiemDataSet.DataSetName = "db_ThiTracNghiemDataSet";
            this.db_ThiTracNghiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(29, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Môn thi";
            // 
            // tblMonHocBindingSource
            // 
            this.tblMonHocBindingSource.DataMember = "tblMonHoc";
            this.tblMonHocBindingSource.DataSource = this.dbThiTracNghiemDataSetBindingSource;
            // 
            // tblMonHocTableAdapter
            // 
            this.tblMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // frmThemPhongThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 310);
            this.Controls.Add(this.cbMon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTaoPhongThi);
            this.Controls.Add(this.btnHuyThemPhongThi);
            this.Controls.Add(this.chkDongPhongthi);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.dtThoiGianTaoPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmThemPhongThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThemPhongThi";
            this.Load += new System.EventHandler(this.frmThemPhongThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbThiTracNghiemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtThoiGianTaoPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.CheckBox chkDongPhongthi;
        private System.Windows.Forms.Button btnHuyThemPhongThi;
        private System.Windows.Forms.Button btnTaoPhongThi;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource dbThiTracNghiemDataSetBindingSource;
        private db_ThiTracNghiemDataSet db_ThiTracNghiemDataSet;
        private System.Windows.Forms.BindingSource tblMonHocBindingSource;
        private db_ThiTracNghiemDataSetTableAdapters.tblMonHocTableAdapter tblMonHocTableAdapter;
        private System.Windows.Forms.BindingSource tblMonHocBindingSource1;
    }
}