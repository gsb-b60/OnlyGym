namespace GymManagerment_MVP.MainFeature.HoaDonRelated.PT._4stepdk
{
    partial class Step1
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
            this.s1flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // s1flp
            // 
            this.s1flp.AutoScroll = true;
            this.s1flp.AutoScrollMargin = new System.Drawing.Size(3, 0);
            this.s1flp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.s1flp.Location = new System.Drawing.Point(0, 0);
            this.s1flp.Name = "s1flp";
            this.s1flp.Size = new System.Drawing.Size(969, 540);
            this.s1flp.TabIndex = 0;
            this.s1flp.Paint += new System.Windows.Forms.PaintEventHandler(this.s1flp_Paint);
            // 
            // Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.s1flp);
            this.Name = "Step1";
            this.Size = new System.Drawing.Size(969, 540);
            this.Load += new System.EventHandler(this.Step1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel s1flp;
    }
}
