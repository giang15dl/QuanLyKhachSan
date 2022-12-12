
namespace QLKhachSan.UI
{
    partial class frmBill
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
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.DocumentSource = typeof(QLKhachSan.UI.XtraReport1);
            this.documentViewer1.IsMetric = false;
            this.documentViewer1.Location = new System.Drawing.Point(0, 0);
            this.documentViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(820, 518);
            this.documentViewer1.TabIndex = 0;
            // 
            // frmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 518);
            this.Controls.Add(this.documentViewer1);
            this.Name = "frmBill";
            this.Text = "frmBill";
            this.Load += new System.EventHandler(this.frmBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
    }
}