namespace cuoiKi
{
    partial class frmDSXeTrong
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
            this.dtgXeTrong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXeTrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgXeTrong
            // 
            this.dtgXeTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXeTrong.Location = new System.Drawing.Point(13, 13);
            this.dtgXeTrong.Name = "dtgXeTrong";
            this.dtgXeTrong.RowHeadersWidth = 51;
            this.dtgXeTrong.RowTemplate.Height = 24;
            this.dtgXeTrong.Size = new System.Drawing.Size(783, 292);
            this.dtgXeTrong.TabIndex = 0;
            // 
            // frmDSXeTrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.dtgXeTrong);
            this.Name = "frmDSXeTrong";
            this.Text = "DSXeTrong";
            this.Load += new System.EventHandler(this.frmDSXeTrong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgXeTrong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgXeTrong;
    }
}