namespace GymManagerment_MVP.MainFeature.Main
{
    partial class FrmCheckIn
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
            this.dgvHocVien = new System.Windows.Forms.DataGridView();
            this.chgCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chGTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chgSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nXoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHocVien
            // 
            this.dgvHocVien.AllowUserToOrderColumns = true;
            this.dgvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chgCode,
            this.chGTen,
            this.chgSDT,
            this.cNgaySinh,
            this.tag,
            this.nTao,
            this.nXoa,
            this.tthai,
            this.TenGT});
            this.dgvHocVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvHocVien.Location = new System.Drawing.Point(0, 0);
            this.dgvHocVien.Name = "dgvHocVien";
            this.dgvHocVien.RowHeadersWidth = 62;
            this.dgvHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocVien.Size = new System.Drawing.Size(562, 325);
            this.dgvHocVien.TabIndex = 1;
            this.dgvHocVien.SelectionChanged += new System.EventHandler(this.dgvHocVien_SelectionChanged);
            this.dgvHocVien.DoubleClick += new System.EventHandler(this.dgvHocVien_DoubleClick);
            // 
            // chgCode
            // 
            this.chgCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.chgCode.DataPropertyName = "code";
            this.chgCode.HeaderText = "Code";
            this.chgCode.MinimumWidth = 8;
            this.chgCode.Name = "chgCode";
            this.chgCode.Width = 57;
            // 
            // chGTen
            // 
            this.chGTen.DataPropertyName = "ten";
            this.chGTen.HeaderText = "Ten";
            this.chGTen.MinimumWidth = 8;
            this.chGTen.Name = "chGTen";
            this.chGTen.Width = 150;
            // 
            // chgSDT
            // 
            this.chgSDT.DataPropertyName = "sdt";
            this.chgSDT.HeaderText = "SDT";
            this.chgSDT.MinimumWidth = 8;
            this.chgSDT.Name = "chgSDT";
            this.chgSDT.Width = 150;
            // 
            // cNgaySinh
            // 
            this.cNgaySinh.DataPropertyName = "ngaySinh";
            this.cNgaySinh.HeaderText = "Ngày Sinh";
            this.cNgaySinh.MinimumWidth = 8;
            this.cNgaySinh.Name = "cNgaySinh";
            this.cNgaySinh.Width = 150;
            // 
            // tag
            // 
            this.tag.DataPropertyName = "gioiTinh";
            this.tag.HeaderText = "Giới tính";
            this.tag.MinimumWidth = 8;
            this.tag.Name = "tag";
            this.tag.Width = 150;
            // 
            // nTao
            // 
            this.nTao.DataPropertyName = "thoiGianTao";
            this.nTao.HeaderText = "Ngày tạo";
            this.nTao.MinimumWidth = 8;
            this.nTao.Name = "nTao";
            this.nTao.Width = 150;
            // 
            // nXoa
            // 
            this.nXoa.DataPropertyName = "ngayXoa";
            this.nXoa.HeaderText = "Ngày xóa";
            this.nXoa.MinimumWidth = 8;
            this.nXoa.Name = "nXoa";
            this.nXoa.Width = 150;
            // 
            // tthai
            // 
            this.tthai.DataPropertyName = "TrangThai";
            this.tthai.HeaderText = "Trạng thái";
            this.tthai.MinimumWidth = 8;
            this.tthai.Name = "tthai";
            this.tthai.Width = 150;
            // 
            // TenGT
            // 
            this.TenGT.DataPropertyName = "tenGoi";
            this.TenGT.HeaderText = "Tên gói tập";
            this.TenGT.MinimumWidth = 8;
            this.TenGT.Name = "TenGT";
            this.TenGT.Width = 150;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(475, 341);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(75, 23);
            this.btnCheckIn.TabIndex = 2;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // FrmCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 376);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dgvHocVien);
            this.Name = "FrmCheckIn";
            this.Text = "FrmCheckIn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn chGTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn chgSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn nTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGT;
        private System.Windows.Forms.Button btnCheckIn;
    }
}