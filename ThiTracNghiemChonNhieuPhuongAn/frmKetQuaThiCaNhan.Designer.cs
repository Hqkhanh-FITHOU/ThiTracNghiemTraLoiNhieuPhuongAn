namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmKetQuaThiCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQuaThiCaNhan));
            this.dvKetQua = new System.Windows.Forms.DataGridView();
            this.PK_sBaithiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhongthiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tThoigianhoanthanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDiemso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaTK = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvKetQua
            // 
            this.dvKetQua.AllowUserToDeleteRows = false;
            this.dvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvKetQua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_sBaithiID,
            this.sPhongthiID,
            this.tThoigianhoanthanh,
            this.fDiemso});
            this.dvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvKetQua.Location = new System.Drawing.Point(3, 16);
            this.dvKetQua.MultiSelect = false;
            this.dvKetQua.Name = "dvKetQua";
            this.dvKetQua.ReadOnly = true;
            this.dvKetQua.RowHeadersVisible = false;
            this.dvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvKetQua.Size = new System.Drawing.Size(724, 513);
            this.dvKetQua.TabIndex = 6;
            this.dvKetQua.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvKetQua_CellDoubleClick);
            // 
            // PK_sBaithiID
            // 
            this.PK_sBaithiID.DataPropertyName = "PK_sBaithiID";
            this.PK_sBaithiID.HeaderText = "Mã bài thi";
            this.PK_sBaithiID.Name = "PK_sBaithiID";
            this.PK_sBaithiID.ReadOnly = true;
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
            // txtMaTK
            // 
            this.txtMaTK.AutoSize = true;
            this.txtMaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTK.Location = new System.Drawing.Point(29, 21);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(89, 17);
            this.txtMaTK.TabIndex = 7;
            this.txtMaTK.Text = "Mã tài khoản";
            // 
            // txtHoten
            // 
            this.txtHoten.AutoSize = true;
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoten.Location = new System.Drawing.Point(124, 21);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(50, 17);
            this.txtHoten.TabIndex = 8;
            this.txtHoten.Text = "Họ tên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvKetQua);
            this.groupBox1.Location = new System.Drawing.Point(18, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 532);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Double click để xem chi tiết bài thi";
            // 
            // frmKetQuaThiCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 636);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMaTK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKetQuaThiCaNhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kế quả cá nhân";
            this.Load += new System.EventHandler(this.frmKetQuaThiCaNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvKetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_sBaithiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhongthiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tThoigianhoanthanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn fDiemso;
        private System.Windows.Forms.Label txtMaTK;
        private System.Windows.Forms.Label txtHoten;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}