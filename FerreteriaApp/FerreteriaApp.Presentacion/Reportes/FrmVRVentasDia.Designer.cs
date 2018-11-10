namespace FerreteriaApp.Presentacion.Reportes
{
    partial class FrmVRVentasDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVRVentasDia));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ferreteriaAppDataSet = new FerreteriaApp.Presentacion.FerreteriaAppDataSet();
            this.uSPRVentasdelDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_R_VentasdelDiaTableAdapter = new FerreteriaApp.Presentacion.FerreteriaAppDataSetTableAdapters.USP_R_VentasdelDiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPRVentasdelDiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSVentasdelDia";
            reportDataSource1.Value = this.uSPRVentasdelDiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FerreteriaApp.Presentacion.Reportes.rdlc.VentasdelDia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // ferreteriaAppDataSet
            // 
            this.ferreteriaAppDataSet.DataSetName = "FerreteriaAppDataSet";
            this.ferreteriaAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPRVentasdelDiaBindingSource
            // 
            this.uSPRVentasdelDiaBindingSource.DataMember = "USP_R_VentasdelDia";
            this.uSPRVentasdelDiaBindingSource.DataSource = this.ferreteriaAppDataSet;
            // 
            // uSP_R_VentasdelDiaTableAdapter
            // 
            this.uSP_R_VentasdelDiaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVRVentasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVRVentasDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas del Día";
            this.Load += new System.EventHandler(this.FrmVRVentasDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPRVentasdelDiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FerreteriaAppDataSet ferreteriaAppDataSet;
        private System.Windows.Forms.BindingSource uSPRVentasdelDiaBindingSource;
        private FerreteriaAppDataSetTableAdapters.USP_R_VentasdelDiaTableAdapter uSP_R_VentasdelDiaTableAdapter;
    }
}