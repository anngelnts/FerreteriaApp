namespace FerreteriaApp.Presentacion.Reportes
{
    partial class FrmVRProductosVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVRProductosVendidos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ferreteriaAppDataSet = new FerreteriaApp.Presentacion.FerreteriaAppDataSet();
            this.uSPRProductosVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_R_ProductosVendidosTableAdapter = new FerreteriaApp.Presentacion.FerreteriaAppDataSetTableAdapters.USP_R_ProductosVendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPRProductosVendidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSProductosSales";
            reportDataSource1.Value = this.uSPRProductosVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FerreteriaApp.Presentacion.Reportes.rdlc.ProductosSales.rdlc";
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
            // uSPRProductosVendidosBindingSource
            // 
            this.uSPRProductosVendidosBindingSource.DataMember = "USP_R_ProductosVendidos";
            this.uSPRProductosVendidosBindingSource.DataSource = this.ferreteriaAppDataSet;
            // 
            // uSP_R_ProductosVendidosTableAdapter
            // 
            this.uSP_R_ProductosVendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVRProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVRProductosVendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Vendidos";
            this.Load += new System.EventHandler(this.FrmVRProductosVendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPRProductosVendidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FerreteriaAppDataSet ferreteriaAppDataSet;
        private System.Windows.Forms.BindingSource uSPRProductosVendidosBindingSource;
        private FerreteriaAppDataSetTableAdapters.USP_R_ProductosVendidosTableAdapter uSP_R_ProductosVendidosTableAdapter;
    }
}