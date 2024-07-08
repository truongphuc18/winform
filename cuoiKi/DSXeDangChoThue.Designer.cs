namespace cuoiKi
{
    partial class frmDSXeDangChoThue
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
            this.dtgXeDangChoThue = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXeDangChoThue)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgXeDangChoThue
            // 
            this.dtgXeDangChoThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXeDangChoThue.Location = new System.Drawing.Point(13, 13);
            this.dtgXeDangChoThue.Name = "dtgXeDangChoThue";
            this.dtgXeDangChoThue.RowHeadersWidth = 51;
            this.dtgXeDangChoThue.RowTemplate.Height = 24;
            this.dtgXeDangChoThue.Size = new System.Drawing.Size(775, 233);
            this.dtgXeDangChoThue.TabIndex = 0;
            // 
            // frmDSXeDangChoThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.dtgXeDangChoThue);
            this.Name = "frmDSXeDangChoThue";
            this.Text = "DSXeDangChoThue";
            this.Load += new System.EventHandler(this.frmDSXeDangChoThue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgXeDangChoThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgXeDangChoThue;
    }
}