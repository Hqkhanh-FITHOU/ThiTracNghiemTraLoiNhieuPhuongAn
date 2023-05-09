namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmChiTietBaiThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietBaiThi));
            this.dvCauTraLoi = new System.Windows.Forms.DataGridView();
            this.iThutuCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuonganA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuonganB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuonganC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuonganD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDapan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuongantraloi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.Label();
            this.txtMaBaithi = new System.Windows.Forms.Label();
            this.txtMaTK = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.Label();
            this.txtThoigianhoanthanh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvCauTraLoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dvCauTraLoi
            // 
            this.dvCauTraLoi.AllowUserToDeleteRows = false;
            this.dvCauTraLoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCauTraLoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iThutuCau,
            this.sNoidung,
            this.sPhuonganA,
            this.sPhuonganB,
            this.sPhuonganC,
            this.sPhuonganD,
            this.sDapan,
            this.sPhuongantraloi});
            this.dvCauTraLoi.Location = new System.Drawing.Point(167, 22);
            this.dvCauTraLoi.Name = "dvCauTraLoi";
            this.dvCauTraLoi.ReadOnly = true;
            this.dvCauTraLoi.RowHeadersVisible = false;
            this.dvCauTraLoi.Size = new System.Drawing.Size(588, 567);
            this.dvCauTraLoi.TabIndex = 0;
            // 
            // iThutuCau
            // 
            this.iThutuCau.DataPropertyName = "iThutuCau";
            this.iThutuCau.HeaderText = "TT";
            this.iThutuCau.Name = "iThutuCau";
            this.iThutuCau.ReadOnly = true;
            this.iThutuCau.Width = 30;
            // 
            // sNoidung
            // 
            this.sNoidung.DataPropertyName = "sNoidung";
            this.sNoidung.HeaderText = "Nội dung câu hỏi";
            this.sNoidung.Name = "sNoidung";
            this.sNoidung.ReadOnly = true;
            this.sNoidung.Width = 200;
            // 
            // sPhuonganA
            // 
            this.sPhuonganA.DataPropertyName = "sPhuonganA";
            this.sPhuonganA.HeaderText = "A";
            this.sPhuonganA.Name = "sPhuonganA";
            this.sPhuonganA.ReadOnly = true;
            this.sPhuonganA.Width = 150;
            // 
            // sPhuonganB
            // 
            this.sPhuonganB.DataPropertyName = "sPhuonganB";
            this.sPhuonganB.HeaderText = "B";
            this.sPhuonganB.Name = "sPhuonganB";
            this.sPhuonganB.ReadOnly = true;
            this.sPhuonganB.Width = 150;
            // 
            // sPhuonganC
            // 
            this.sPhuonganC.DataPropertyName = "sPhuonganC";
            this.sPhuonganC.HeaderText = "C";
            this.sPhuonganC.Name = "sPhuonganC";
            this.sPhuonganC.ReadOnly = true;
            this.sPhuonganC.Width = 150;
            // 
            // sPhuonganD
            // 
            this.sPhuonganD.DataPropertyName = "sPhuonganD";
            this.sPhuonganD.HeaderText = "D";
            this.sPhuonganD.Name = "sPhuonganD";
            this.sPhuonganD.ReadOnly = true;
            this.sPhuonganD.Width = 150;
            // 
            // sDapan
            // 
            this.sDapan.DataPropertyName = "sDapan";
            this.sDapan.HeaderText = "Đáp án";
            this.sDapan.Name = "sDapan";
            this.sDapan.ReadOnly = true;
            this.sDapan.Width = 50;
            // 
            // sPhuongantraloi
            // 
            this.sPhuongantraloi.DataPropertyName = "sPhuongantraloi";
            this.sPhuongantraloi.HeaderText = "Phương án đã chọn";
            this.sPhuongantraloi.Name = "sPhuongantraloi";
            this.sPhuongantraloi.ReadOnly = true;
            this.sPhuongantraloi.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bài thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(5, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng thi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(5, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã thí sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(5, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ tên thí sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(5, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thời gian hoàn thành:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(5, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điểm số:";
            // 
            // txtHoten
            // 
            this.txtHoten.AutoSize = true;
            this.txtHoten.Location = new System.Drawing.Point(8, 205);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(47, 13);
            this.txtHoten.TabIndex = 7;
            this.txtHoten.Text = "txtHoten";
            // 
            // txtMaBaithi
            // 
            this.txtMaBaithi.AutoSize = true;
            this.txtMaBaithi.Location = new System.Drawing.Point(7, 47);
            this.txtMaBaithi.Name = "txtMaBaithi";
            this.txtMaBaithi.Size = new System.Drawing.Size(59, 13);
            this.txtMaBaithi.TabIndex = 8;
            this.txtMaBaithi.Text = "txtMaBaithi";
            // 
            // txtMaTK
            // 
            this.txtMaTK.AutoSize = true;
            this.txtMaTK.Location = new System.Drawing.Point(7, 146);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(47, 13);
            this.txtMaTK.TabIndex = 9;
            this.txtMaTK.Text = "txtMaTK";
            // 
            // txtDiem
            // 
            this.txtDiem.AutoSize = true;
            this.txtDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiem.ForeColor = System.Drawing.Color.Red;
            this.txtDiem.Location = new System.Drawing.Point(67, 306);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(61, 17);
            this.txtDiem.TabIndex = 10;
            this.txtDiem.Text = "txtDiem";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.AutoSize = true;
            this.txtMaPhong.Location = new System.Drawing.Point(7, 94);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(64, 13);
            this.txtMaPhong.TabIndex = 11;
            this.txtMaPhong.Text = "txtMaPhong";
            // 
            // txtThoigianhoanthanh
            // 
            this.txtThoigianhoanthanh.AutoSize = true;
            this.txtThoigianhoanthanh.Location = new System.Drawing.Point(8, 270);
            this.txtThoigianhoanthanh.Name = "txtThoigianhoanthanh";
            this.txtThoigianhoanthanh.Size = new System.Drawing.Size(110, 13);
            this.txtThoigianhoanthanh.TabIndex = 12;
            this.txtThoigianhoanthanh.Text = "txtThoigianhoanthanh";
            // 
            // frmChiTietBaiThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 616);
            this.Controls.Add(this.txtThoigianhoanthanh);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtMaTK);
            this.Controls.Add(this.txtMaBaithi);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvCauTraLoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChiTietBaiThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết bài thi";
            this.Load += new System.EventHandler(this.frmChiTietBaiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvCauTraLoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvCauTraLoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtHoten;
        private System.Windows.Forms.Label txtMaBaithi;
        private System.Windows.Forms.Label txtMaTK;
        private System.Windows.Forms.Label txtDiem;
        private System.Windows.Forms.Label txtMaPhong;
        private System.Windows.Forms.Label txtThoigianhoanthanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn iThutuCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuonganA;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuonganB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuonganC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuonganD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDapan;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuongantraloi;
    }
}