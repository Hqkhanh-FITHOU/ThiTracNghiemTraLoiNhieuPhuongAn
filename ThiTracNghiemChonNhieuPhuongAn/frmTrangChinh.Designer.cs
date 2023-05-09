namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmTrangChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangChinh));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTaiKhoan = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCaiDatTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThi = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnQuanLyPhongThi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLamBaiThi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCauHoiThi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKetQuaThi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLop = new System.Windows.Forms.ToolStripButton();
            this.btnMonThi = new System.Windows.Forms.ToolStripButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTaiKhoan,
            this.btnThi,
            this.btnLop,
            this.btnMonThi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(958, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuanLyTaiKhoan,
            this.btnCaiDatTaiKhoan,
            this.btnDangXuat});
            this.btnTaiKhoan.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.profile_female_user_icon_251458;
            this.btnTaiKhoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(109, 36);
            this.btnTaiKhoan.Text = "Tài khoản";
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.users_40493;
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(207, 26);
            this.btnQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnCaiDatTaiKhoan
            // 
            this.btnCaiDatTaiKhoan.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.person_account_profile_settings_options_icon_124632;
            this.btnCaiDatTaiKhoan.Name = "btnCaiDatTaiKhoan";
            this.btnCaiDatTaiKhoan.Size = new System.Drawing.Size(207, 26);
            this.btnCaiDatTaiKhoan.Text = "Hồ sơ tài khoản";
            this.btnCaiDatTaiKhoan.Click += new System.EventHandler(this.btnCaiDatTaiKhoan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.Logout_37127;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(207, 26);
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThi
            // 
            this.btnThi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuanLyPhongThi,
            this.btnLamBaiThi,
            this.btnCauHoiThi,
            this.btnKetQuaThi});
            this.btnThi.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.exam_sheet_test_school_study_icon_209259;
            this.btnThi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThi.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(67, 36);
            this.btnThi.Text = "Thi";
            // 
            // btnQuanLyPhongThi
            // 
            this.btnQuanLyPhongThi.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.hat_school_icon;
            this.btnQuanLyPhongThi.Name = "btnQuanLyPhongThi";
            this.btnQuanLyPhongThi.Size = new System.Drawing.Size(210, 26);
            this.btnQuanLyPhongThi.Text = "Quản lý phòng thi";
            this.btnQuanLyPhongThi.Click += new System.EventHandler(this.quảnLýPhòngThiToolStripMenuItem_Click);
            // 
            // btnLamBaiThi
            // 
            this.btnLamBaiThi.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.test_exam_icon_182954;
            this.btnLamBaiThi.Name = "btnLamBaiThi";
            this.btnLamBaiThi.Size = new System.Drawing.Size(210, 26);
            this.btnLamBaiThi.Text = "Làm bài thi";
            this.btnLamBaiThi.Click += new System.EventHandler(this.btnLamBaiThi_Click);
            // 
            // btnCauHoiThi
            // 
            this.btnCauHoiThi.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.question_icon;
            this.btnCauHoiThi.Name = "btnCauHoiThi";
            this.btnCauHoiThi.Size = new System.Drawing.Size(210, 26);
            this.btnCauHoiThi.Text = "Câu hỏi thi";
            this.btnCauHoiThi.Click += new System.EventHandler(this.btnCauHoiThi_Click);
            // 
            // btnKetQuaThi
            // 
            this.btnKetQuaThi.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.grade_icon;
            this.btnKetQuaThi.Name = "btnKetQuaThi";
            this.btnKetQuaThi.Size = new System.Drawing.Size(210, 26);
            this.btnKetQuaThi.Text = "Kết quả thi";
            this.btnKetQuaThi.Click += new System.EventHandler(this.btnKetQuaThi_Click);
            // 
            // btnLop
            // 
            this.btnLop.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.teacher_education_school_lecture_student_icon_141984;
            this.btnLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLop.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(62, 36);
            this.btnLop.Text = "Lớp";
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnMonThi
            // 
            this.btnMonThi.Image = global::ThiTracNghiemChonNhieuPhuongAn.Properties.Resources.subject_icon;
            this.btnMonThi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMonThi.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnMonThi.Name = "btnMonThi";
            this.btnMonThi.Size = new System.Drawing.Size(88, 28);
            this.btnMonThi.Text = "Môn thi";
            this.btnMonThi.Visible = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 49);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(958, 746);
            this.panelChildForm.TabIndex = 1;
            // 
            // frmTrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(766, 636);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrangChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thi trắc nghiệm";
            this.Load += new System.EventHandler(this.frmTrangChinh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem btnQuanLyTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem btnCaiDatTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem btnDangXuat;
        private System.Windows.Forms.ToolStripDropDownButton btnThi;
        private System.Windows.Forms.ToolStripMenuItem btnQuanLyPhongThi;
        private System.Windows.Forms.ToolStripMenuItem btnLamBaiThi;
        private System.Windows.Forms.ToolStripMenuItem btnCauHoiThi;
        private System.Windows.Forms.ToolStripMenuItem btnKetQuaThi;
        private System.Windows.Forms.ToolStripButton btnLop;
        private System.Windows.Forms.ToolStripButton btnMonThi;
        private System.Windows.Forms.Panel panelChildForm;
    }
}