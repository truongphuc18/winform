namespace cuoiKi
{
    partial class frmHopDong
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
            this.dtgHopDong = new System.Windows.Forms.DataGridView();
            this.lblMaHopDong = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblMaXe = new System.Windows.Forms.Label();
            this.lblNgayThue = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblNgayTraThat = new System.Windows.Forms.Label();
            this.lblThoiGianThue = new System.Windows.Forms.Label();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.txtMAHD = new System.Windows.Forms.TextBox();
            this.txtTongChiPhi = new System.Windows.Forms.TextBox();
            this.txtMAXEHD = new System.Windows.Forms.TextBox();
            this.txtMAKHHD = new System.Windows.Forms.TextBox();
            this.dtpGioThue = new System.Windows.Forms.DateTimePicker();
            this.dtpGioTra = new System.Windows.Forms.DateTimePicker();
            this.dtpGioTraThat = new System.Windows.Forms.DateTimePicker();
            this.txtThoiGianThue = new System.Windows.Forms.TextBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayTraThat = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiemHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnResetHD = new System.Windows.Forms.Button();
            this.lblTimMAHD = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHopDong)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgHopDong
            // 
            this.dtgHopDong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHopDong.Location = new System.Drawing.Point(16, 16);
            this.dtgHopDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgHopDong.Name = "dtgHopDong";
            this.dtgHopDong.RowHeadersWidth = 51;
            this.dtgHopDong.RowTemplate.Height = 24;
            this.dtgHopDong.Size = new System.Drawing.Size(969, 274);
            this.dtgHopDong.TabIndex = 0;
            // 
            // lblMaHopDong
            // 
            this.lblMaHopDong.AutoSize = true;
            this.lblMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHopDong.Location = new System.Drawing.Point(13, 304);
            this.lblMaHopDong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHopDong.Name = "lblMaHopDong";
            this.lblMaHopDong.Size = new System.Drawing.Size(105, 20);
            this.lblMaHopDong.TabIndex = 1;
            this.lblMaHopDong.Text = "Mã hợp đồng";
            this.lblMaHopDong.Click += new System.EventHandler(this.lblMaHopDong_Click);
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(13, 339);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(122, 20);
            this.lblMaKH.TabIndex = 2;
            this.lblMaKH.Text = "Mã khách hàng";
            this.lblMaKH.Click += new System.EventHandler(this.lblMaKH_Click);
            // 
            // lblMaXe
            // 
            this.lblMaXe.AutoSize = true;
            this.lblMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaXe.Location = new System.Drawing.Point(13, 382);
            this.lblMaXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaXe.Name = "lblMaXe";
            this.lblMaXe.Size = new System.Drawing.Size(54, 20);
            this.lblMaXe.TabIndex = 3;
            this.lblMaXe.Text = "Mã xe";
            this.lblMaXe.Click += new System.EventHandler(this.lblMaXe_Click);
            // 
            // lblNgayThue
            // 
            this.lblNgayThue.AutoSize = true;
            this.lblNgayThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThue.Location = new System.Drawing.Point(13, 414);
            this.lblNgayThue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayThue.Name = "lblNgayThue";
            this.lblNgayThue.Size = new System.Drawing.Size(84, 20);
            this.lblNgayThue.TabIndex = 4;
            this.lblNgayThue.Text = "Ngày thuê";
            this.lblNgayThue.Click += new System.EventHandler(this.lblNgayThue_Click);
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Location = new System.Drawing.Point(13, 455);
            this.lblNgayTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(77, 20);
            this.lblNgayTra.TabIndex = 5;
            this.lblNgayTra.Text = "Ngày Trả";
            this.lblNgayTra.Click += new System.EventHandler(this.lblNgayTra_Click);
            // 
            // lblNgayTraThat
            // 
            this.lblNgayTraThat.AutoSize = true;
            this.lblNgayTraThat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTraThat.Location = new System.Drawing.Point(13, 483);
            this.lblNgayTraThat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgayTraThat.Name = "lblNgayTraThat";
            this.lblNgayTraThat.Size = new System.Drawing.Size(105, 20);
            this.lblNgayTraThat.TabIndex = 6;
            this.lblNgayTraThat.Text = "Ngày trả thật";
            this.lblNgayTraThat.Click += new System.EventHandler(this.lblNgayTraThat_Click);
            // 
            // lblThoiGianThue
            // 
            this.lblThoiGianThue.AutoSize = true;
            this.lblThoiGianThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGianThue.Location = new System.Drawing.Point(13, 521);
            this.lblThoiGianThue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThoiGianThue.Name = "lblThoiGianThue";
            this.lblThoiGianThue.Size = new System.Drawing.Size(114, 20);
            this.lblThoiGianThue.TabIndex = 7;
            this.lblThoiGianThue.Text = "Thời gian thuê";
            this.lblThoiGianThue.Click += new System.EventHandler(this.lblThoiGianThue_Click);
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChiPhi.Location = new System.Drawing.Point(13, 568);
            this.lblTongChiPhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(100, 20);
            this.lblTongChiPhi.TabIndex = 8;
            this.lblTongChiPhi.Text = "Tổng chi phí";
            this.lblTongChiPhi.Click += new System.EventHandler(this.lblTongChiPhi_Click);
            // 
            // txtMAHD
            // 
            this.txtMAHD.Location = new System.Drawing.Point(159, 304);
            this.txtMAHD.Multiline = true;
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.Size = new System.Drawing.Size(200, 29);
            this.txtMAHD.TabIndex = 9;
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.Location = new System.Drawing.Point(159, 565);
            this.txtTongChiPhi.Multiline = true;
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.Size = new System.Drawing.Size(200, 29);
            this.txtTongChiPhi.TabIndex = 11;
            // 
            // txtMAXEHD
            // 
            this.txtMAXEHD.Location = new System.Drawing.Point(159, 373);
            this.txtMAXEHD.Multiline = true;
            this.txtMAXEHD.Name = "txtMAXEHD";
            this.txtMAXEHD.Size = new System.Drawing.Size(200, 29);
            this.txtMAXEHD.TabIndex = 12;
            // 
            // txtMAKHHD
            // 
            this.txtMAKHHD.Location = new System.Drawing.Point(159, 339);
            this.txtMAKHHD.Multiline = true;
            this.txtMAKHHD.Name = "txtMAKHHD";
            this.txtMAKHHD.Size = new System.Drawing.Size(200, 29);
            this.txtMAKHHD.TabIndex = 13;
            // 
            // dtpGioThue
            // 
            this.dtpGioThue.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpGioThue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioThue.Location = new System.Drawing.Point(159, 407);
            this.dtpGioThue.Name = "dtpGioThue";
            this.dtpGioThue.Size = new System.Drawing.Size(200, 27);
            this.dtpGioThue.TabIndex = 14;
            this.dtpGioThue.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpGioTra
            // 
            this.dtpGioTra.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioTra.Location = new System.Drawing.Point(159, 450);
            this.dtpGioTra.Name = "dtpGioTra";
            this.dtpGioTra.Size = new System.Drawing.Size(200, 27);
            this.dtpGioTra.TabIndex = 15;
            // 
            // dtpGioTraThat
            // 
            this.dtpGioTraThat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioTraThat.Location = new System.Drawing.Point(159, 483);
            this.dtpGioTraThat.Name = "dtpGioTraThat";
            this.dtpGioTraThat.Size = new System.Drawing.Size(200, 27);
            this.dtpGioTraThat.TabIndex = 16;
            // 
            // txtThoiGianThue
            // 
            this.txtThoiGianThue.Location = new System.Drawing.Point(159, 521);
            this.txtThoiGianThue.Name = "txtThoiGianThue";
            this.txtThoiGianThue.Size = new System.Drawing.Size(200, 27);
            this.txtThoiGianThue.TabIndex = 17;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(365, 450);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayTra.TabIndex = 18;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThue.Location = new System.Drawing.Point(365, 408);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayThue.TabIndex = 19;
            // 
            // dtpNgayTraThat
            // 
            this.dtpNgayTraThat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTraThat.Location = new System.Drawing.Point(365, 483);
            this.dtpNgayTraThat.Name = "dtpNgayTraThat";
            this.dtpNgayTraThat.Size = new System.Drawing.Size(200, 27);
            this.dtpNgayTraThat.TabIndex = 20;
            // 
            // btnTimKiemHD
            // 
            this.btnTimKiemHD.Location = new System.Drawing.Point(36, 137);
            this.btnTimKiemHD.Name = "btnTimKiemHD";
            this.btnTimKiemHD.Size = new System.Drawing.Size(133, 49);
            this.btnTimKiemHD.TabIndex = 21;
            this.btnTimKiemHD.Text = "Tìm kiếm";
            this.btnTimKiemHD.UseVisualStyleBackColor = true;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Location = new System.Drawing.Point(596, 310);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(133, 49);
            this.btnThemHD.TabIndex = 22;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.UseVisualStyleBackColor = true;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Location = new System.Drawing.Point(596, 386);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(133, 49);
            this.btnSuaHD.TabIndex = 23;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.UseVisualStyleBackColor = true;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(596, 468);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(133, 49);
            this.btnXoaHD.TabIndex = 24;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.textBox1);
            this.grbTimKiem.Controls.Add(this.lblTimMAHD);
            this.grbTimKiem.Controls.Add(this.btnTimKiemHD);
            this.grbTimKiem.Location = new System.Drawing.Point(777, 346);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(208, 202);
            this.grbTimKiem.TabIndex = 25;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnResetHD
            // 
            this.btnResetHD.Location = new System.Drawing.Point(596, 539);
            this.btnResetHD.Name = "btnResetHD";
            this.btnResetHD.Size = new System.Drawing.Size(133, 49);
            this.btnResetHD.TabIndex = 25;
            this.btnResetHD.Text = "Reset";
            this.btnResetHD.UseVisualStyleBackColor = true;
            // 
            // lblTimMAHD
            // 
            this.lblTimMAHD.AutoSize = true;
            this.lblTimMAHD.Location = new System.Drawing.Point(7, 36);
            this.lblTimMAHD.Name = "lblTimMAHD";
            this.lblTimMAHD.Size = new System.Drawing.Size(105, 20);
            this.lblTimMAHD.TabIndex = 22;
            this.lblTimMAHD.Text = "Mã hợp đồng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 78);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 33);
            this.textBox1.TabIndex = 23;
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 659);
            this.Controls.Add(this.btnResetHD);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.btnSuaHD);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.dtpNgayTraThat);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.txtThoiGianThue);
            this.Controls.Add(this.dtpGioTraThat);
            this.Controls.Add(this.dtpGioTra);
            this.Controls.Add(this.dtpGioThue);
            this.Controls.Add(this.txtMAKHHD);
            this.Controls.Add(this.txtMAXEHD);
            this.Controls.Add(this.txtTongChiPhi);
            this.Controls.Add(this.txtMAHD);
            this.Controls.Add(this.lblTongChiPhi);
            this.Controls.Add(this.lblThoiGianThue);
            this.Controls.Add(this.lblNgayTraThat);
            this.Controls.Add(this.lblNgayTra);
            this.Controls.Add(this.lblNgayThue);
            this.Controls.Add(this.lblMaXe);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblMaHopDong);
            this.Controls.Add(this.dtgHopDong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHopDong";
            this.Text = "HopDong";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHopDong)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgHopDong;
        private System.Windows.Forms.Label lblMaHopDong;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblMaXe;
        private System.Windows.Forms.Label lblNgayThue;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblNgayTraThat;
        private System.Windows.Forms.Label lblThoiGianThue;
        private System.Windows.Forms.Label lblTongChiPhi;
        private System.Windows.Forms.TextBox txtMAHD;
        private System.Windows.Forms.TextBox txtTongChiPhi;
        private System.Windows.Forms.TextBox txtMAXEHD;
        private System.Windows.Forms.TextBox txtMAKHHD;
        private System.Windows.Forms.DateTimePicker dtpGioThue;
        private System.Windows.Forms.DateTimePicker dtpGioTra;
        private System.Windows.Forms.DateTimePicker dtpGioTraThat;
        private System.Windows.Forms.TextBox txtThoiGianThue;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.DateTimePicker dtpNgayTraThat;
        private System.Windows.Forms.Button btnTimKiemHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnResetHD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTimMAHD;
    }
}