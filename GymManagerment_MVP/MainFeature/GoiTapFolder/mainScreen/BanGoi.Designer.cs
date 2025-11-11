namespace GymManagerment_MVP.MainFeature.HoaDonRelated
{
    partial class BanGoi
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flpGoiThang = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flpGoiBuoi = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.cbUnActive = new System.Windows.Forms.CheckBox();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.lblTT = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.btnChinhSuaGoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblKHD = new System.Windows.Forms.Label();
            this.lblDHD = new System.Windows.Forms.Label();
            this.lblTKTong = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(207, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(762, 648);
            this.panel3.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 35);
            this.tabControl1.Location = new System.Drawing.Point(20, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 612);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flpGoiThang);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gói Tập Tháng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flpGoiThang
            // 
            this.flpGoiThang.AutoScroll = true;
            this.flpGoiThang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpGoiThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGoiThang.Location = new System.Drawing.Point(3, 3);
            this.flpGoiThang.Name = "flpGoiThang";
            this.flpGoiThang.Size = new System.Drawing.Size(708, 563);
            this.flpGoiThang.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flpGoiBuoi);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gói Theo Buổi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flpGoiBuoi
            // 
            this.flpGoiBuoi.AutoScroll = true;
            this.flpGoiBuoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpGoiBuoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGoiBuoi.Location = new System.Drawing.Point(3, 3);
            this.flpGoiBuoi.Name = "flpGoiBuoi";
            this.flpGoiBuoi.Size = new System.Drawing.Size(708, 563);
            this.flpGoiBuoi.TabIndex = 1;
            this.flpGoiBuoi.Paint += new System.Windows.Forms.PaintEventHandler(this.tb2flp_Paint);
            // 
            // pnlLoc
            // 
            this.pnlLoc.AutoScroll = true;
            this.pnlLoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLoc.Controls.Add(this.lblKHD);
            this.pnlLoc.Controls.Add(this.lblDHD);
            this.pnlLoc.Controls.Add(this.lblTKTong);
            this.pnlLoc.Controls.Add(this.cbUnActive);
            this.pnlLoc.Controls.Add(this.cbActive);
            this.pnlLoc.Controls.Add(this.lblTT);
            this.pnlLoc.Controls.Add(this.lblT);
            this.pnlLoc.Controls.Add(this.btnChinhSuaGoi);
            this.pnlLoc.Controls.Add(this.btnXoa);
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoc.Location = new System.Drawing.Point(0, 0);
            this.pnlLoc.Name = "pnlLoc";
            this.pnlLoc.Padding = new System.Windows.Forms.Padding(20);
            this.pnlLoc.Size = new System.Drawing.Size(207, 648);
            this.pnlLoc.TabIndex = 31;
            // 
            // cbUnActive
            // 
            this.cbUnActive.AutoSize = true;
            this.cbUnActive.Location = new System.Drawing.Point(23, 124);
            this.cbUnActive.Name = "cbUnActive";
            this.cbUnActive.Size = new System.Drawing.Size(112, 17);
            this.cbUnActive.TabIndex = 46;
            this.cbUnActive.Text = "Không Hoạt Động";
            this.cbUnActive.UseVisualStyleBackColor = true;
            this.cbUnActive.CheckedChanged += new System.EventHandler(this.cbUnActive_CheckedChanged);
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(23, 89);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(107, 17);
            this.cbActive.TabIndex = 45;
            this.cbActive.Text = "Đang Hoạt Động";
            this.cbActive.UseVisualStyleBackColor = true;
            this.cbActive.CheckedChanged += new System.EventHandler(this.cbActive_CheckedChanged);
            // 
            // lblTT
            // 
            this.lblTT.AutoSize = true;
            this.lblTT.Location = new System.Drawing.Point(20, 59);
            this.lblTT.Name = "lblTT";
            this.lblTT.Size = new System.Drawing.Size(59, 13);
            this.lblTT.TabIndex = 44;
            this.lblTT.Text = "Trạng Thái";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(23, 16);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(32, 13);
            this.lblT.TabIndex = 42;
            this.lblT.Text = "Tổng";
            // 
            // btnChinhSuaGoi
            // 
            this.btnChinhSuaGoi.Location = new System.Drawing.Point(17, 602);
            this.btnChinhSuaGoi.Name = "btnChinhSuaGoi";
            this.btnChinhSuaGoi.Size = new System.Drawing.Size(167, 23);
            this.btnChinhSuaGoi.TabIndex = 40;
            this.btnChinhSuaGoi.Text = "Thêm Gói Tập";
            this.btnChinhSuaGoi.UseVisualStyleBackColor = true;
            this.btnChinhSuaGoi.Click += new System.EventHandler(this.btnChinhSuaGoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(17, 562);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(167, 23);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa tất cả";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblKHD
            // 
            this.lblKHD.Location = new System.Drawing.Point(141, 124);
            this.lblKHD.Name = "lblKHD";
            this.lblKHD.Size = new System.Drawing.Size(43, 23);
            this.lblKHD.TabIndex = 52;
            this.lblKHD.Text = "del count";
            this.lblKHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDHD
            // 
            this.lblDHD.Location = new System.Drawing.Point(136, 89);
            this.lblDHD.Name = "lblDHD";
            this.lblDHD.Size = new System.Drawing.Size(48, 23);
            this.lblDHD.TabIndex = 51;
            this.lblDHD.Text = "unac count";
            this.lblDHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDHD.Click += new System.EventHandler(this.lblTKUnactive_Click);
            // 
            // lblTKTong
            // 
            this.lblTKTong.Location = new System.Drawing.Point(114, 11);
            this.lblTKTong.Name = "lblTKTong";
            this.lblTKTong.Size = new System.Drawing.Size(70, 23);
            this.lblTKTong.TabIndex = 50;
            this.lblTKTong.Text = "ac count";
            this.lblTKTong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BanGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlLoc);
            this.Name = "BanGoi";
            this.Size = new System.Drawing.Size(969, 648);
            this.Load += new System.EventHandler(this.BanGoi_Load);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flpGoiThang;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSuaGoi;
        private System.Windows.Forms.FlowLayoutPanel flpGoiBuoi;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.Label lblTT;
        private System.Windows.Forms.CheckBox cbUnActive;
        private System.Windows.Forms.Label lblKHD;
        private System.Windows.Forms.Label lblDHD;
        private System.Windows.Forms.Label lblTKTong;
    }
}
