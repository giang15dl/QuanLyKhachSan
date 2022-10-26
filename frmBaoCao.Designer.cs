
namespace QLKhachSan
{
    partial class frmBaoCao
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.btnBaoCaoKhachHang = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QLKSDataSet = new QLKhachSan.QLKSDataSet();
            this.tKhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKhachTableAdapter = new QLKhachSan.QLKSDataSetTableAdapters.tKhachTableAdapter();
            this.btnBaoCaoPhong = new System.Windows.Forms.Button();
            this.btnBaoCaoThietBi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKhachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBaoCaoKhachHang
            // 
            this.btnBaoCaoKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBaoCaoKhachHang.Location = new System.Drawing.Point(99, 23);
            this.btnBaoCaoKhachHang.Name = "btnBaoCaoKhachHang";
            this.btnBaoCaoKhachHang.Size = new System.Drawing.Size(220, 61);
            this.btnBaoCaoKhachHang.TabIndex = 0;
            this.btnBaoCaoKhachHang.Text = "Xem danh sách Khách hàng";
            this.btnBaoCaoKhachHang.UseVisualStyleBackColor = true;
            this.btnBaoCaoKhachHang.Click += new System.EventHandler(this.btnBaoCaoKhachHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 483);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // report
            // 
            this.report.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Data_KhachHang";
            reportDataSource1.Value = this.tKhachBindingSource;
            this.report.LocalReport.DataSources.Add(reportDataSource1);
            this.report.LocalReport.ReportEmbeddedResource = "QLKhachSan.DanhSachKhachHang.rdlc";
            this.report.Location = new System.Drawing.Point(3, 18);
            this.report.Name = "report";
            this.report.ServerReport.BearerToken = null;
            this.report.Size = new System.Drawing.Size(1017, 462);
            this.report.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBaoCaoThietBi);
            this.groupBox2.Controls.Add(this.btnBaoCaoPhong);
            this.groupBox2.Controls.Add(this.btnBaoCaoKhachHang);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn";
            // 
            // QLKSDataSet
            // 
            this.QLKSDataSet.DataSetName = "QLKSDataSet";
            this.QLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKhachBindingSource
            // 
            this.tKhachBindingSource.DataMember = "tKhach";
            this.tKhachBindingSource.DataSource = this.QLKSDataSet;
            // 
            // tKhachTableAdapter
            // 
            this.tKhachTableAdapter.ClearBeforeFill = true;
            // 
            // btnBaoCaoPhong
            // 
            this.btnBaoCaoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBaoCaoPhong.Location = new System.Drawing.Point(349, 28);
            this.btnBaoCaoPhong.Name = "btnBaoCaoPhong";
            this.btnBaoCaoPhong.Size = new System.Drawing.Size(201, 51);
            this.btnBaoCaoPhong.TabIndex = 1;
            this.btnBaoCaoPhong.Text = "Xem danh sách Phòng";
            this.btnBaoCaoPhong.UseVisualStyleBackColor = true;
            this.btnBaoCaoPhong.Click += new System.EventHandler(this.btnBaoCaoPhong_Click);
            // 
            // btnBaoCaoThietBi
            // 
            this.btnBaoCaoThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBaoCaoThietBi.Location = new System.Drawing.Point(582, 32);
            this.btnBaoCaoThietBi.Name = "btnBaoCaoThietBi";
            this.btnBaoCaoThietBi.Size = new System.Drawing.Size(190, 42);
            this.btnBaoCaoThietBi.TabIndex = 2;
            this.btnBaoCaoThietBi.Text = "Xem danh sách Thiết bị";
            this.btnBaoCaoThietBi.UseVisualStyleBackColor = true;
            this.btnBaoCaoThietBi.Click += new System.EventHandler(this.btnBaoCaoThietBi_Click);
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKhachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBaoCaoKhachHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer report;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource tKhachBindingSource;
        private QLKSDataSet QLKSDataSet;
        private QLKSDataSetTableAdapters.tKhachTableAdapter tKhachTableAdapter;
        private System.Windows.Forms.Button btnBaoCaoPhong;
        private System.Windows.Forms.Button btnBaoCaoThietBi;
    }
}