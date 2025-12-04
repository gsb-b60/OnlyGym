namespace GymManagerment_MVP.MainFeature.HocVienRelated
{
    partial class ThongTinCheckInUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLichSuTap = new System.Windows.Forms.GroupBox();
            this.dgvSession = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.gbLastCheck = new System.Windows.Forms.GroupBox();
            this.dtpDenCheckin = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpTuCheckin = new System.Windows.Forms.DateTimePicker();
            this.chEND = new System.Windows.Forms.CheckBox();
            this.cbH = new System.Windows.Forms.CheckBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.gbLichSuTap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).BeginInit();
            this.gbLastCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLichSuTap
            // 
            this.gbLichSuTap.Controls.Add(this.dgvSession);
            this.gbLichSuTap.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbLichSuTap.Location = new System.Drawing.Point(170, 0);
            this.gbLichSuTap.Name = "gbLichSuTap";
            this.gbLichSuTap.Size = new System.Drawing.Size(967, 324);
            this.gbLichSuTap.TabIndex = 36;
            this.gbLichSuTap.TabStop = false;
            this.gbLichSuTap.Text = "Lich Su Tap";
            // 
            // dgvSession
            // 
            this.dgvSession.AllowUserToAddRows = false;
            this.dgvSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column19,
            this.Column17,
            this.Column20,
            this.Column18,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dgvSession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSession.Location = new System.Drawing.Point(3, 16);
            this.dgvSession.Name = "dgvSession";
            this.dgvSession.RowHeadersWidth = 62;
            this.dgvSession.Size = new System.Drawing.Size(961, 305);
            this.dgvSession.TabIndex = 1;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ID";
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "hopDong";
            this.Column19.HeaderText = "hopDong";
            this.Column19.Name = "Column19";
            this.Column19.Visible = false;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "TenHocVien";
            this.Column17.HeaderText = "TenHocVien";
            this.Column17.Name = "Column17";
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column20.DataPropertyName = "TenPT";
            this.Column20.HeaderText = "TenPT";
            this.Column20.Name = "Column20";
            this.Column20.Width = 65;
            // 
            // Column18
            // 
            this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column18.DataPropertyName = "TenGoi";
            this.Column18.HeaderText = "TenGoi";
            this.Column18.Name = "Column18";
            this.Column18.Visible = false;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column10.DataPropertyName = "IDHopDong";
            this.Column10.HeaderText = "IDHopDong";
            this.Column10.Name = "Column10";
            this.Column10.Width = 89;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "TGBatDau";
            this.Column11.HeaderText = "TGBatDau";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TGKetThuc";
            this.Column12.HeaderText = "TGKetThuc";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column13.DataPropertyName = "TrangThai";
            this.Column13.HeaderText = "TrangThai";
            this.Column13.Name = "Column13";
            this.Column13.Width = 81;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "ThoiGianTao";
            this.Column14.HeaderText = "ThoiGianTao";
            this.Column14.Name = "Column14";
            this.Column14.Visible = false;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "ThoiGianHuy";
            this.Column15.HeaderText = "ThoiGianHuy";
            this.Column15.Name = "Column15";
            this.Column15.Visible = false;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "LyDoHuy";
            this.Column16.HeaderText = "LyDoHuy";
            this.Column16.Name = "Column16";
            this.Column16.Visible = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(20, 292);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(131, 23);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xóa tất cả";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // gbLastCheck
            // 
            this.gbLastCheck.Controls.Add(this.dtpDenCheckin);
            this.gbLastCheck.Controls.Add(this.btnLoc);
            this.gbLastCheck.Controls.Add(this.lblDen);
            this.gbLastCheck.Controls.Add(this.lblTu);
            this.gbLastCheck.Controls.Add(this.dtpTuCheckin);
            this.gbLastCheck.Location = new System.Drawing.Point(20, 142);
            this.gbLastCheck.Name = "gbLastCheck";
            this.gbLastCheck.Size = new System.Drawing.Size(131, 131);
            this.gbLastCheck.TabIndex = 27;
            this.gbLastCheck.TabStop = false;
            this.gbLastCheck.Text = "Thời Gian Check In";
            // 
            // dtpDenCheckin
            // 
            this.dtpDenCheckin.CustomFormat = "dd/MM/yyyy";
            this.dtpDenCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenCheckin.Location = new System.Drawing.Point(6, 90);
            this.dtpDenCheckin.Name = "dtpDenCheckin";
            this.dtpDenCheckin.Size = new System.Drawing.Size(105, 20);
            this.dtpDenCheckin.TabIndex = 24;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(33, 135);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(83, 23);
            this.btnLoc.TabIndex = 13;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(3, 74);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(27, 13);
            this.lblDen.TabIndex = 23;
            this.lblDen.Text = "Đến";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(3, 35);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(20, 13);
            this.lblTu.TabIndex = 22;
            this.lblTu.Text = "Từ";
            // 
            // dtpTuCheckin
            // 
            this.dtpTuCheckin.CustomFormat = "dd/MM/yyyy";
            this.dtpTuCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuCheckin.Location = new System.Drawing.Point(6, 51);
            this.dtpTuCheckin.Name = "dtpTuCheckin";
            this.dtpTuCheckin.Size = new System.Drawing.Size(105, 20);
            this.dtpTuCheckin.TabIndex = 21;
            // 
            // chEND
            // 
            this.chEND.AutoSize = true;
            this.chEND.Location = new System.Drawing.Point(20, 72);
            this.chEND.Name = "chEND";
            this.chEND.Size = new System.Drawing.Size(63, 17);
            this.chEND.TabIndex = 39;
            this.chEND.Text = "Từ Chối";
            this.chEND.UseVisualStyleBackColor = true;
            // 
            // cbH
            // 
            this.cbH.AutoSize = true;
            this.cbH.Location = new System.Drawing.Point(20, 49);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(61, 17);
            this.cbH.TabIndex = 38;
            this.cbH.Text = "Hợp Lệ";
            this.cbH.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(17, 16);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(46, 13);
            this.lblTrangThai.TabIndex = 37;
            this.lblTrangThai.Text = "Kết Quả";
            // 
            // ThongTinCheckInUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chEND);
            this.Controls.Add(this.cbH);
            this.Controls.Add(this.lblTrangThai);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gbLichSuTap);
            this.Controls.Add(this.gbLastCheck);
            this.Name = "ThongTinCheckInUC";
            this.Size = new System.Drawing.Size(1137, 324);
            this.Load += new System.EventHandler(this.ThongTinCheckInUC_Load);
            this.gbLichSuTap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).EndInit();
            this.gbLastCheck.ResumeLayout(false);
            this.gbLastCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLichSuTap;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox gbLastCheck;
        private System.Windows.Forms.DateTimePicker dtpDenCheckin;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtpTuCheckin;
        private System.Windows.Forms.CheckBox chEND;
        private System.Windows.Forms.CheckBox cbH;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.DataGridView dgvSession;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
    }
}
