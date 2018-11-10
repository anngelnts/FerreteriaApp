namespace FerreteriaApp.Presentacion.Reportes
{
    partial class FrmVRExistenciaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVRExistenciaProductos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ferreteriaAppDataSet = new FerreteriaApp.Presentacion.FerreteriaAppDataSet();
            this.uSPRExistenciaProductosOrderExistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSP_R_ExistenciaProductosOrderExistenciaTableAdapter = new FerreteriaApp.Presentacion.FerreteriaAppDataSetTableAdapters.USP_R_ExistenciaProductosOrderExistenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPRExistenciaProductosOrderExistenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSExistenciaProductos";
            reportDataSource1.Value = this.uSPRExistenciaProductosOrderExistenciaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FerreteriaApp.Presentacion.Reportes.rdlc.ExisteniaProductos.rdlc";
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
            // uSPRExistenciaProductosOrderExistenciaBindingSource
            // 
            this.uSPRExistenciaProductosOrderExistenciaBindingSource.DataMember = "USP_R_ExistenciaProductosOrderExistencia";
            this.uSPRExistenciaProductosOrderExistenciaBindingSource.DataSource = this.ferreteriaAppDataSet;
            // 
            // uSP_R_ExistenciaProductosOrderExistenciaTableAdapter
            // 
            this.uSP_R_ExistenciaProductosOrderExistenciaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVRExistenciaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVRExistenciaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Existencia de Productos";
            this.Load += new System.EventHandler(this.FrmVRExistenciaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPRExistenciaProductosOrderExistenciaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FerreteriaAppDataSet ferreteriaAppDataSet;
        private System.Windows.Forms.BindingSource uSPRExistenciaProductosOrderExistenciaBindingSource;
        private FerreteriaAppDataSetTableAdapters.USP_R_ExistenciaProductosOrderExistenciaTableAdapter uSP_R_ExistenciaProductosOrderExistenciaTableAdapter;
    }
}