namespace ThiTracNghiemChonNhieuPhuongAn
{
    partial class frmQuanLyCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyCauHoi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLocTheoMon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoaCauHoi = new System.Windows.Forms.Button();
            this.btnSuaCauHoi = new System.Windows.Forms.Button();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvDanhSachCauHoi = new System.Windows.Forms.DataGridView();
            this.PK_sCauhoiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMonID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuonganA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuonganB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuonganC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPhuonganD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDapan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.tblMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_ThiTracNghiemDataSet = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSet();
            this.txtDapAn = new System.Windows.Forms.TextBox();
            this.txtPA4 = new System.Windows.Forms.TextBox();
            this.txtPA3 = new System.Windows.Forms.TextBox();
            this.txtPA2 = new System.Windows.Forms.TextBox();
            this.txtPA1 = new System.Windows.Forms.TextBox();
            this.txtNoiDungCauHoi = new System.Windows.Forms.TextBox();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblMonHocTableAdapter = new ThiTracNghiemChonNhieuPhuongAn.db_ThiTracNghiemDataSetTableAdapters.tblMonHocTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhSachCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnLocTheoMon);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbMon);
            this.panel1.Controls.Add(this.txtDapAn);
            this.panel1.Controls.Add(this.txtPA4);
            this.panel1.Controls.Add(this.txtPA3);
            this.panel1.Controls.Add(this.txtPA2);
            this.panel1.Controls.Add(this.txtPA1);
            this.panel1.Controls.Add(this.txtNoiDungCauHoi);
            this.panel1.Controls.Add(this.txtMaCauHoi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 571);
            this.panel1.TabIndex = 0;
            // 
            // btnLocTheoMon
            // 
            this.btnLocTheoMon.Location = new System.Drawing.Point(559, 489);
            this.btnLocTheoMon.Name = "btnLocTheoMon";
            this.btnLocTheoMon.Size = new System.Drawing.Size(80, 23);
            this.btnLocTheoMon.TabIndex = 24;
            this.btnLocTheoMon.Text = "Lọc theo môn";
            this.btnLocTheoMon.UseVisualStyleBackColor = true;
            this.btnLocTheoMon.Click += new System.EventHandler(this.btnLocTheoMon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoaCauHoi);
            this.groupBox2.Controls.Add(this.btnSuaCauHoi);
            this.groupBox2.Controls.Add(this.btnThemCauHoi);
            this.groupBox2.Location = new System.Drawing.Point(491, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 176);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy chọn";
            // 
            // btnXoaCauHoi
            // 
            this.btnXoaCauHoi.Location = new System.Drawing.Point(6, 123);
            this.btnXoaCauHoi.Name = "btnXoaCauHoi";
            this.btnXoaCauHoi.Size = new System.Drawing.Size(188, 40);
            this.btnXoaCauHoi.TabIndex = 21;
            this.btnXoaCauHoi.Text = "Xóa";
            this.btnXoaCauHoi.UseVisualStyleBackColor = true;
            this.btnXoaCauHoi.Click += new System.EventHandler(this.btnXoaCauHoi_Click);
            // 
            // btnSuaCauHoi
            // 
            this.btnSuaCauHoi.Location = new System.Drawing.Point(6, 71);
            this.btnSuaCauHoi.Name = "btnSuaCauHoi";
            this.btnSuaCauHoi.Size = new System.Drawing.Size(188, 40);
            this.btnSuaCauHoi.TabIndex = 20;
            this.btnSuaCauHoi.Text = "Sửa";
            this.btnSuaCauHoi.UseVisualStyleBackColor = true;
            this.btnSuaCauHoi.Click += new System.EventHandler(this.btnSuaCauHoi_Click);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(6, 19);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(188, 40);
            this.btnThemCauHoi.TabIndex = 19;
            this.btnThemCauHoi.Text = "Thêm câu hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(645, 489);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Làm mới";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dvDanhSachCauHoi);
            this.groupBox1.Location = new System.Drawing.Point(15, 510);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 530);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách câu hỏi";
            // 
            // dvDanhSachCauHoi
            // 
            this.dvDanhSachCauHoi.AllowUserToDeleteRows = false;
            this.dvDanhSachCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDanhSachCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_sCauhoiID,
            this.iMonID,
            this.sNoidung,
            this.sPhuonganA,
            this.sPhuonganB,
            this.sPhuonganC,
            this.sPhuonganD,
            this.sDapan});
            this.dvDanhSachCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvDanhSachCauHoi.Location = new System.Drawing.Point(3, 16);
            this.dvDanhSachCauHoi.MultiSelect = false;
            this.dvDanhSachCauHoi.Name = "dvDanhSachCauHoi";
            this.dvDanhSachCauHoi.ReadOnly = true;
            this.dvDanhSachCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDanhSachCauHoi.Size = new System.Drawing.Size(701, 511);
            this.dvDanhSachCauHoi.TabIndex = 17;
            this.dvDanhSachCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvDanhSachCauHoi_CellClick);
            // 
            // PK_sCauhoiID
            // 
            this.PK_sCauhoiID.DataPropertyName = "PK_sCauhoiID";
            this.PK_sCauhoiID.HeaderText = "Mã câu hỏi";
            this.PK_sCauhoiID.Name = "PK_sCauhoiID";
            this.PK_sCauhoiID.ReadOnly = true;
            // 
            // iMonID
            // 
            this.iMonID.DataPropertyName = "iMonID";
            this.iMonID.HeaderText = "Mã môn";
            this.iMonID.Name = "iMonID";
            this.iMonID.ReadOnly = true;
            // 
            // sNoidung
            // 
            this.sNoidung.DataPropertyName = "sNoidung";
            this.sNoidung.HeaderText = "Nội dung câu hỏi";
            this.sNoidung.Name = "sNoidung";
            this.sNoidung.ReadOnly = true;
            // 
            // sPhuonganA
            // 
            this.sPhuonganA.DataPropertyName = "sPhuonganA";
            this.sPhuonganA.HeaderText = "A";
            this.sPhuonganA.Name = "sPhuonganA";
            this.sPhuonganA.ReadOnly = true;
            // 
            // sPhuonganB
            // 
            this.sPhuonganB.DataPropertyName = "sPhuonganB";
            this.sPhuonganB.HeaderText = "B";
            this.sPhuonganB.Name = "sPhuonganB";
            this.sPhuonganB.ReadOnly = true;
            // 
            // sPhuonganC
            // 
            this.sPhuonganC.DataPropertyName = "sPhuonganC";
            this.sPhuonganC.HeaderText = "C";
            this.sPhuonganC.Name = "sPhuonganC";
            this.sPhuonganC.ReadOnly = true;
            // 
            // sPhuonganD
            // 
            this.sPhuonganD.DataPropertyName = "sPhuonganD";
            this.sPhuonganD.HeaderText = "D";
            this.sPhuonganD.Name = "sPhuonganD";
            this.sPhuonganD.ReadOnly = true;
            // 
            // sDapan
            // 
            this.sDapan.DataPropertyName = "sDapan";
            this.sDapan.HeaderText = "Đáp án";
            this.sDapan.Name = "sDapan";
            this.sDapan.ReadOnly = true;
            // 
            // cbMon
            // 
            this.cbMon.DataSource = this.tblMonHocBindingSource;
            this.cbMon.DisplayMember = "sTenmonhoc";
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(101, 65);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(371, 21);
            this.cbMon.TabIndex = 16;
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
            // txtDapAn
            // 
            this.txtDapAn.Location = new System.Drawing.Point(101, 448);
            this.txtDapAn.Name = "txtDapAn";
            this.txtDapAn.Size = new System.Drawing.Size(371, 20);
            this.txtDapAn.TabIndex = 15;
            // 
            // txtPA4
            // 
            this.txtPA4.Location = new System.Drawing.Point(101, 388);
            this.txtPA4.Multiline = true;
            this.txtPA4.Name = "txtPA4";
            this.txtPA4.Size = new System.Drawing.Size(371, 40);
            this.txtPA4.TabIndex = 14;
            // 
            // txtPA3
            // 
            this.txtPA3.Location = new System.Drawing.Point(101, 326);
            this.txtPA3.Multiline = true;
            this.txtPA3.Name = "txtPA3";
            this.txtPA3.Size = new System.Drawing.Size(371, 40);
            this.txtPA3.TabIndex = 13;
            // 
            // txtPA2
            // 
            this.txtPA2.Location = new System.Drawing.Point(101, 269);
            this.txtPA2.Multiline = true;
            this.txtPA2.Name = "txtPA2";
            this.txtPA2.Size = new System.Drawing.Size(371, 40);
            this.txtPA2.TabIndex = 12;
            // 
            // txtPA1
            // 
            this.txtPA1.Location = new System.Drawing.Point(101, 207);
            this.txtPA1.Multiline = true;
            this.txtPA1.Name = "txtPA1";
            this.txtPA1.Size = new System.Drawing.Size(371, 40);
            this.txtPA1.TabIndex = 11;
            // 
            // txtNoiDungCauHoi
            // 
            this.txtNoiDungCauHoi.Location = new System.Drawing.Point(101, 109);
            this.txtNoiDungCauHoi.Multiline = true;
            this.txtNoiDungCauHoi.Name = "txtNoiDungCauHoi";
            this.txtNoiDungCauHoi.Size = new System.Drawing.Size(371, 79);
            this.txtNoiDungCauHoi.TabIndex = 10;
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Location = new System.Drawing.Point(101, 22);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.Size = new System.Drawing.Size(371, 20);
            this.txtMaCauHoi.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Môn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Đáp án";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phương án D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phương án C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phương án B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phương án A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã câu hỏi";
            // 
            // tblMonHocTableAdapter
            // 
            this.tblMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // frmQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 571);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuanLyCauHoi";
            this.Text = " Quản lý câu hỏi";
            this.Load += new System.EventHandler(this.frmQuanLyCauHoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDanhSachCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_ThiTracNghiemDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.TextBox txtDapAn;
        private System.Windows.Forms.TextBox txtPA4;
        private System.Windows.Forms.TextBox txtPA3;
        private System.Windows.Forms.TextBox txtPA2;
        private System.Windows.Forms.TextBox txtPA1;
        private System.Windows.Forms.TextBox txtNoiDungCauHoi;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private db_ThiTracNghiemDataSet db_ThiTracNghiemDataSet;
        private System.Windows.Forms.BindingSource tblMonHocBindingSource;
        private db_ThiTracNghiemDataSetTableAdapters.tblMonHocTableAdapter tblMonHocTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvDanhSachCauHoi;
        private System.Windows.Forms.Button btnXoaCauHoi;
        private System.Windows.Forms.Button btnSuaCauHoi;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_sCauhoiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMonID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuonganA;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuonganB;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuonganC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPhuonganD;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDapan;
        private System.Windows.Forms.Button btnLocTheoMon;
    }
}