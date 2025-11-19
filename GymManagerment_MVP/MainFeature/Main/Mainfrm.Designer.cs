namespace GymManagerment_MVP
{
    partial class Mainfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinGóiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinGóiTậpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinGóiPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinHãngSảnXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChuyểnKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinChuyênMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDSPT = new System.Windows.Forms.Button();
            this.btnDanhSachKH = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHome.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.Teal;
            this.pnlHome.Controls.Add(this.btnLogOut);
            this.pnlHome.Controls.Add(this.lblChucVu);
            this.pnlHome.Controls.Add(this.lblAccName);
            this.pnlHome.Controls.Add(this.menuStrip1);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(0, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1264, 27);
            this.pnlHome.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Teal;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnLogOut.FlatAppearance.BorderSize = 5;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Location = new System.Drawing.Point(1044, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 21);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.BackColor = System.Drawing.Color.Teal;
            this.lblChucVu.Location = new System.Drawing.Point(978, 9);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(60, 13);
            this.lblChucVu.TabIndex = 7;
            this.lblChucVu.Text = "Chu Phong";
            this.lblChucVu.Click += new System.EventHandler(this.lblChucVu_Click);
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.BackColor = System.Drawing.Color.Teal;
            this.lblAccName.Location = new System.Drawing.Point(878, 9);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(94, 13);
            this.lblAccName.TabIndex = 6;
            this.lblAccName.Text = "Nguyen Dinh Hieu";
            this.lblAccName.Click += new System.EventHandler(this.lblAccName_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinGóiTậpToolStripMenuItem,
            this.thôngTinChuyểnKhoảnToolStripMenuItem,
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.thôngTinChuyênMônToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thôngTinGóiTậpToolStripMenuItem
            // 
            this.thôngTinGóiTậpToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.thôngTinGóiTậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinGóiTậpToolStripMenuItem1,
            this.thôngTinGóiPTToolStripMenuItem,
            this.thôngTinHãngSảnXuấtToolStripMenuItem1});
            this.thôngTinGóiTậpToolStripMenuItem.Name = "thôngTinGóiTậpToolStripMenuItem";
            this.thôngTinGóiTậpToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
            this.thôngTinGóiTậpToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinGóiTậpToolStripMenuItem.Click += new System.EventHandler(this.thôngTinGóiTậpToolStripMenuItem_Click);
            // 
            // thôngTinGóiTậpToolStripMenuItem1
            // 
            this.thôngTinGóiTậpToolStripMenuItem1.Name = "thôngTinGóiTậpToolStripMenuItem1";
            this.thôngTinGóiTậpToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.thôngTinGóiTậpToolStripMenuItem1.Text = "Thông tin gói tập";
            // 
            // thôngTinGóiPTToolStripMenuItem
            // 
            this.thôngTinGóiPTToolStripMenuItem.Name = "thôngTinGóiPTToolStripMenuItem";
            this.thôngTinGóiPTToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.thôngTinGóiPTToolStripMenuItem.Text = "Thông tin gói PT";
            // 
            // thôngTinHãngSảnXuấtToolStripMenuItem1
            // 
            this.thôngTinHãngSảnXuấtToolStripMenuItem1.Name = "thôngTinHãngSảnXuấtToolStripMenuItem1";
            this.thôngTinHãngSảnXuấtToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.thôngTinHãngSảnXuấtToolStripMenuItem1.Text = "Thông tin hãng sản xuất";
            // 
            // thôngTinChuyểnKhoảnToolStripMenuItem
            // 
            this.thôngTinChuyểnKhoảnToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Name = "thôngTinChuyểnKhoảnToolStripMenuItem";
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Text = "Thông Tin Chuyển Khoản";
            this.thôngTinChuyểnKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinChuyểnKhoảnToolStripMenuItem_Click);
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng Dẫn Sử Dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // thôngTinChuyênMônToolStripMenuItem
            // 
            this.thôngTinChuyênMônToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.thôngTinChuyênMônToolStripMenuItem.Name = "thôngTinChuyênMônToolStripMenuItem";
            this.thôngTinChuyênMônToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.thôngTinChuyênMônToolStripMenuItem.Text = "Thông Tin Chuyên Môn";
            this.thôngTinChuyênMônToolStripMenuItem.Click += new System.EventHandler(this.thôngTinChuyênMônToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Teal;
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.btnDSPT);
            this.pnlMenu.Controls.Add(this.btnDanhSachKH);
            this.pnlMenu.Controls.Add(this.btnCheckin);
            this.pnlMenu.Controls.Add(this.btnQuanLyNhanVien);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 27);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1264, 31);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.Teal;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnThongKe.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(675, 0);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(8);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(135, 31);
            this.btnThongKe.TabIndex = 15;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(540, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Contracts";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnDSPT
            // 
            this.btnDSPT.BackColor = System.Drawing.Color.Teal;
            this.btnDSPT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDSPT.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnDSPT.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDSPT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnDSPT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnDSPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSPT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDSPT.Location = new System.Drawing.Point(405, 0);
            this.btnDSPT.Margin = new System.Windows.Forms.Padding(8);
            this.btnDSPT.Name = "btnDSPT";
            this.btnDSPT.Size = new System.Drawing.Size(135, 31);
            this.btnDSPT.TabIndex = 9;
            this.btnDSPT.Text = "PT";
            this.btnDSPT.UseVisualStyleBackColor = false;
            this.btnDSPT.Click += new System.EventHandler(this.btnDSPT_Click);
            // 
            // btnDanhSachKH
            // 
            this.btnDanhSachKH.BackColor = System.Drawing.Color.Teal;
            this.btnDanhSachKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDanhSachKH.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnDanhSachKH.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnDanhSachKH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnDanhSachKH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnDanhSachKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachKH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDanhSachKH.Location = new System.Drawing.Point(270, 0);
            this.btnDanhSachKH.Margin = new System.Windows.Forms.Padding(8);
            this.btnDanhSachKH.Name = "btnDanhSachKH";
            this.btnDanhSachKH.Size = new System.Drawing.Size(135, 31);
            this.btnDanhSachKH.TabIndex = 8;
            this.btnDanhSachKH.Text = "List Customer";
            this.btnDanhSachKH.UseVisualStyleBackColor = false;
            this.btnDanhSachKH.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.BackColor = System.Drawing.Color.Teal;
            this.btnCheckin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCheckin.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnCheckin.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnCheckin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnCheckin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnCheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckin.Location = new System.Drawing.Point(135, 0);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(8);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(135, 31);
            this.btnCheckin.TabIndex = 5;
            this.btnCheckin.Text = "Check In";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.Teal;
            this.btnQuanLyNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLyNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnQuanLyNhanVien.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnQuanLyNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnQuanLyNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(8);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(135, 31);
            this.btnQuanLyNhanVien.TabIndex = 3;
            this.btnQuanLyNhanVien.Text = "Shop";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 58);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1264, 624);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainfrm";
            this.Text = "Only Gym";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Button btnDanhSachKH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGóiTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGóiTậpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinGóiPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinHãngSảnXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChuyểnKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.Button btnDSPT;
        private System.Windows.Forms.ToolStripMenuItem thôngTinChuyênMônToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnThongKe;
    }
}