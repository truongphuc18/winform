namespace cuoiKi
{
    partial class frmXeHong
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
            this.dtgXeHong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXeHong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgXeHong
            // 
            this.dtgXeHong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXeHong.Location = new System.Drawing.Point(12, 12);
            this.dtgXeHong.Name = "dtgXeHong";
            this.dtgXeHong.RowHeadersWidth = 51;
            this.dtgXeHong.RowTemplate.Height = 24;
            this.dtgXeHong.Size = new System.Drawing.Size(786, 201);
            this.dtgXeHong.TabIndex = 0;
            // 
            // frmXeHong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 234);
            this.Controls.Add(this.dtgXeHong);
            this.Name = "frmXeHong";
            this.Text = "DSXeHong";
            this.Load += new System.EventHandler(this.frmXeHong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgXeHong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgXeHong;
    }
}