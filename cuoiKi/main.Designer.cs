namespace cuoiKi
{
    partial class frmMain
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
            this.lblGreat = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDSXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXeTrong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXeDaChoThue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXeHong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfoKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXeThue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHopDongThue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoangThue = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGreat
            // 
            this.lblGreat.AutoSize = true;
            this.lblGreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreat.Location = new System.Drawing.Point(25, 196);
            this.lblGreat.Name = "lblGreat";
            this.lblGreat.Size = new System.Drawing.Size(714, 38);
            this.lblGreat.TabIndex = 0;
            this.lblGreat.Text = "Chào mừng bạn đến với dịch vụ cho thuê xe !";
            this.lblGreat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSXe,
            this.mnuInfoKH,
            this.mnuXeThue,
            this.liênHệToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDSXe
            // 
            this.mnuDSXe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXeTrong,
            this.mnuXeDaChoThue,
            this.mnuXeHong,
            this.tìmXeToolStripMenuItem,
            this.thêmXeToolStripMenuItem});
            this.mnuDSXe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDSXe.Name = "mnuDSXe";
            this.mnuDSXe.Size = new System.Drawing.Size(128, 27);
            this.mnuDSXe.Text = "Danh sách xe";
            // 
            // mnuXeTrong
            // 
            this.mnuXeTrong.Name = "mnuXeTrong";
            this.mnuXeTrong.Size = new System.Drawing.Size(224, 28);
            this.mnuXeTrong.Text = "Xe trống";
            this.mnuXeTrong.Click += new System.EventHandler(this.mnuXeTrong_Click);
            // 
            // mnuXeDaChoThue
            // 
            this.mnuXeDaChoThue.Name = "mnuXeDaChoThue";
            this.mnuXeDaChoThue.Size = new System.Drawing.Size(224, 28);
            this.mnuXeDaChoThue.Text = "Xe đã cho thuê";
            this.mnuXeDaChoThue.Click += new System.EventHandler(this.mnuXeDaChoThue_Click);
            // 
            // mnuXeHong
            // 
            this.mnuXeHong.Name = "mnuXeHong";
            this.mnuXeHong.Size = new System.Drawing.Size(224, 28);
            this.mnuXeHong.Text = "Xe đang hỏng";
            this.mnuXeHong.Click += new System.EventHandler(this.mnuXeHong_Click);
            // 
            // mnuInfoKH
            // 
            this.mnuInfoKH.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuInfoKH.Name = "mnuInfoKH";
            this.mnuInfoKH.Size = new System.Drawing.Size(199, 27);
            this.mnuInfoKH.Text = "Thông tin khách hàng";
            this.mnuInfoKH.Click += new System.EventHandler(this.tìmXeToolStripMenuItem_Click);
            // 
            // mnuXeThue
            // 
            this.mnuXeThue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHopDongThue,
            this.mnuKhoangThue});
            this.mnuXeThue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuXeThue.Name = "mnuXeThue";
            this.mnuXeThue.Size = new System.Drawing.Size(88, 27);
            this.mnuXeThue.Text = "Xe Thuê";
            // 
            // mnuHopDongThue
            // 
            this.mnuHopDongThue.Name = "mnuHopDongThue";
            this.mnuHopDongThue.Size = new System.Drawing.Size(240, 28);
            this.mnuHopDongThue.Text = "Hợp đồng thuê xe";
            this.mnuHopDongThue.Click += new System.EventHandler(this.mnuHopDongThue_Click);
            // 
            // mnuKhoangThue
            // 
            this.mnuKhoangThue.Name = "mnuKhoangThue";
            this.mnuKhoangThue.Size = new System.Drawing.Size(240, 28);
            this.mnuKhoangThue.Text = "Khoảng thuê";
            // 
            // tìmXeToolStripMenuItem
            // 
            this.tìmXeToolStripMenuItem.Name = "tìmXeToolStripMenuItem";
            this.tìmXeToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.tìmXeToolStripMenuItem.Text = "Tìm xe";
            // 
            // thêmXeToolStripMenuItem
            // 
            this.thêmXeToolStripMenuItem.Name = "thêmXeToolStripMenuItem";
            this.thêmXeToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.thêmXeToolStripMenuItem.Text = "Thêm xe";
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(81, 27);
            this.liênHệToolStripMenuItem.Text = "Liên hệ";
            this.liênHệToolStripMenuItem.Click += new System.EventHandler(this.liênHệToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGreat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDSXe;
        private System.Windows.Forms.ToolStripMenuItem mnuXeTrong;
        private System.Windows.Forms.ToolStripMenuItem mnuXeDaChoThue;
        private System.Windows.Forms.ToolStripMenuItem mnuInfoKH;
        private System.Windows.Forms.ToolStripMenuItem mnuXeHong;
        private System.Windows.Forms.ToolStripMenuItem mnuXeThue;
        private System.Windows.Forms.ToolStripMenuItem mnuHopDongThue;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoangThue;
        private System.Windows.Forms.ToolStripMenuItem tìmXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmXeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
    }
}