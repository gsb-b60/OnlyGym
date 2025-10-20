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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "27/08/2025-06:10",
            "Accept",
            ""}, -1);
            this.gbLichSuTap = new System.Windows.Forms.GroupBox();
            this.lvLichSuTap = new System.Windows.Forms.ListView();
            this.chThoigian = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGhiChú = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLyDo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLanCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.gbLastCheck.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLichSuTap
            // 
            this.gbLichSuTap.Controls.Add(this.lvLichSuTap);
            this.gbLichSuTap.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbLichSuTap.Location = new System.Drawing.Point(170, 0);
            this.gbLichSuTap.Name = "gbLichSuTap";
            this.gbLichSuTap.Size = new System.Drawing.Size(967, 324);
            this.gbLichSuTap.TabIndex = 36;
            this.gbLichSuTap.TabStop = false;
            this.gbLichSuTap.Text = "Lich Su Tap";
            // 
            // lvLichSuTap
            // 
            this.lvLichSuTap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chThoigian,
            this.chKQ,
            this.chGhiChú,
            this.chLyDo,
            this.chLanCheckIn});
            this.lvLichSuTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLichSuTap.GridLines = true;
            this.lvLichSuTap.HideSelection = false;
            this.lvLichSuTap.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvLichSuTap.Location = new System.Drawing.Point(3, 16);
            this.lvLichSuTap.Margin = new System.Windows.Forms.Padding(0);
            this.lvLichSuTap.Name = "lvLichSuTap";
            this.lvLichSuTap.Size = new System.Drawing.Size(961, 305);
            this.lvLichSuTap.TabIndex = 0;
            this.lvLichSuTap.UseCompatibleStateImageBehavior = false;
            this.lvLichSuTap.View = System.Windows.Forms.View.Details;
            // 
            // chThoigian
            // 
            this.chThoigian.Text = "Thời gian";
            this.chThoigian.Width = 117;
            // 
            // chKQ
            // 
            this.chKQ.Text = "Kết Quả";
            this.chKQ.Width = 66;
            // 
            // chGhiChú
            // 
            this.chGhiChú.Text = "Ghi Chú";
            this.chGhiChú.Width = 285;
            // 
            // chLyDo
            // 
            this.chLyDo.Text = "Lý Do";
            this.chLyDo.Width = 142;
            // 
            // chLanCheckIn
            // 
            this.chLanCheckIn.Text = "Lan CheckIn";
            this.chLanCheckIn.Width = 232;
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
            this.gbLastCheck.ResumeLayout(false);
            this.gbLastCheck.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLichSuTap;
        private System.Windows.Forms.ListView lvLichSuTap;
        private System.Windows.Forms.ColumnHeader chThoigian;
        private System.Windows.Forms.ColumnHeader chKQ;
        private System.Windows.Forms.ColumnHeader chGhiChú;
        private System.Windows.Forms.ColumnHeader chLyDo;
        private System.Windows.Forms.ColumnHeader chLanCheckIn;
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
    }
}
