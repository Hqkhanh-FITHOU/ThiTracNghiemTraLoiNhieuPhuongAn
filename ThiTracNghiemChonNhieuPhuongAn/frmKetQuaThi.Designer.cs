namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmKetQuaThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQuaThi));
            this.db_ThiTracNghiemDataSet = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSet();
            this.tblPhongThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPhongThiTableAdapter = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSetTableAdapters.tblPhongThiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.cbPhongthi = new System.Windows.Forms.ComboBox();
            this.dvKetQua = new System.Windows.Forms.DataGridView();
            this.PK_sBaithiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTaikhoanID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhongthiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tThoigianhoanthanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiemso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongThiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // db_ThiTracNghiemDataSet
            // 
            this.db_ThiTracNghiemDataSet.DataSetName = "db_ThiTracNghiemDataSet";
            this.db_ThiTracNghiemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPhongThiBindingSource
            // 
            this.tblPhongThiBindingSource.DataMember = "tblPhongThi";
            this.tblPhongThiBindingSource.DataSource = this.db_ThiTracNghiemDataSet;
            // 
            // tblPhongThiTableAdapter
            // 
            this.tblPhongThiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "phòng thi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(686, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Tất cả";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(545, 44);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(135, 31);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Text = "Báo cáo bảng điểm";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // cbPhongthi
            // 
            this.cbPhongthi.DataSource = this.tblPhongThiBindingSource;
            this.cbPhongthi.DisplayMember = "sTenphongthi";
            this.cbPhongthi.FormattingEnabled = true;
            this.cbPhongthi.Location = new System.Drawing.Point(85, 44);
            this.cbPhongthi.Name = "cbPhongthi";
            this.cbPhongthi.Size = new System.Drawing.Size(208, 21);
            this.cbPhongthi.TabIndex = 6;
            this.cbPhongthi.ValueMember = "PK_sPhongthiID";
            this.cbPhongthi.SelectedIndexChanged += new System.EventHandler(this.cbPhongthi_SelectedIndexChanged);
            // 
            // dvKetQua
            // 
            this.dvKetQua.AllowUserToDeleteRows = false;
            this.dvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_sBaithiID,
            this.sTaikhoanID,
            this.sPhongthiID,
            this.tThoigianhoanthanh,
            this.fDiemso});
            this.dvKetQua.Location = new System.Drawing.Point(30, 81);
            this.dvKetQua.MultiSelect = false;
            this.dvKetQua.Name = "dvKetQua";
            this.dvKetQua.ReadOnly = true;
            this.dvKetQua.RowHeadersVisible = false;
            this.dvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvKetQua.Size = new System.Drawing.Size(706, 511);
            this.dvKetQua.TabIndex = 5;
            this.dvKetQua.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvKetQua_CellDoubleClick);
            // 
            // PK_sBaithiID
            // 
            this.PK_sBaithiID.DataPropertyName = "PK_sBaithiID";
            this.PK_sBaithiID.HeaderText = "Mã bài thi";
            this.PK_sBaithiID.Name = "PK_sBaithiID";
            this.PK_sBaithiID.ReadOnly = true;
            // 
            // sTaikhoanID
            // 
            this.sTaikhoanID.DataPropertyName = "sTaikhoanID";
            this.sTaikhoanID.HeaderText = "Mã thí sinh";
            this.sTaikhoanID.Name = "sTaikhoanID";
            this.sTaikhoanID.ReadOnly = true;
            // 
            // sPhongthiID
            // 
            this.sPhongthiID.DataPropertyName = "sPhongthiID";
            this.sPhongthiID.HeaderText = "Mã phòng";
            this.sPhongthiID.Name = "sPhongthiID";
            this.sPhongthiID.ReadOnly = true;
            // 
            // tThoigianhoanthanh
            // 
            this.tThoigianhoanthanh.DataPropertyName = "tThoigianhoanthanh";
            this.tThoigianhoanthanh.HeaderText = "Thời gian hoàn thành";
            this.tThoigianhoanthanh.Name = "tThoigianhoanthanh";
            this.tThoigianhoanthanh.ReadOnly = true;
            // 
            // fDiemso
            // 
            this.fDiemso.DataPropertyName = "fDiemso";
            this.fDiemso.HeaderText = "Điểm số";
            this.fDiemso.Name = "fDiemso";
            this.fDiemso.ReadOnly = true;
            // 
            // frmKetQuaThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(766, 636);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.cbPhongthi);
            this.Controls.Add(this.dvKetQua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKetQuaThi";
            this.Text = "Quản lý kết quả thi";
            this.Load += new System.EventHandler(this.frmKetQuaThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhongThiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private db_ThiTracNghiemDataSet db_ThiTracNghiemDataSet;
        private System.Windows.Forms.BindingSource tblPhongThiBindingSource;
        private db_ThiTracNghiemDataSetTableAdapters.tblPhongThiTableAdapter tblPhongThiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.ComboBox cbPhongthi;
        private System.Windows.Forms.DataGridView dvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_sBaithiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTaikhoanID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhongthiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tThoigianhoanthanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiemso;
    }
}