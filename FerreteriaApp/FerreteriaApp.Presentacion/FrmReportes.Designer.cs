namespace FerreteriaApp.Presentacion
{
    partial class FrmReportes
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
            this.BtnExistenciaProductos = new System.Windows.Forms.Button();
            this.BtnProductosVendidos = new System.Windows.Forms.Button();
            this.BtnVentasDia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExistenciaProductos
            // 
            this.BtnExistenciaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnExistenciaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExistenciaProductos.FlatAppearance.BorderSize = 0;
            this.BtnExistenciaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExistenciaProductos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExistenciaProductos.ForeColor = System.Drawing.Color.White;
            this.BtnExistenciaProductos.Location = new System.Drawing.Point(30, 45);
            this.BtnExistenciaProductos.Name = "BtnExistenciaProductos";
            this.BtnExistenciaProductos.Size = new System.Drawing.Size(210, 40);
            this.BtnExistenciaProductos.TabIndex = 8;
            this.BtnExistenciaProductos.Text = "Existencia de Productos";
            this.BtnExistenciaProductos.UseVisualStyleBackColor = false;
            this.BtnExistenciaProductos.Click += new System.EventHandler(this.BtnExistenciaProductos_Click);
            // 
            // BtnProductosVendidos
            // 
            this.BtnProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnProductosVendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductosVendidos.FlatAppearance.BorderSize = 0;
            this.BtnProductosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductosVendidos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductosVendidos.ForeColor = System.Drawing.Color.White;
            this.BtnProductosVendidos.Location = new System.Drawing.Point(30, 91);
            this.BtnProductosVendidos.Name = "BtnProductosVendidos";
            this.BtnProductosVendidos.Size = new System.Drawing.Size(210, 40);
            this.BtnProductosVendidos.TabIndex = 9;
            this.BtnProductosVendidos.Text = "Productos Vendidos";
            this.BtnProductosVendidos.UseVisualStyleBackColor = false;
            this.BtnProductosVendidos.Click += new System.EventHandler(this.BtnProductosVendidos_Click);
            // 
            // BtnVentasDia
            // 
            this.BtnVentasDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnVentasDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentasDia.FlatAppearance.BorderSize = 0;
            this.BtnVentasDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentasDia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentasDia.ForeColor = System.Drawing.Color.White;
            this.BtnVentasDia.Location = new System.Drawing.Point(30, 137);
            this.BtnVentasDia.Name = "BtnVentasDia";
            this.BtnVentasDia.Size = new System.Drawing.Size(210, 40);
            this.BtnVentasDia.TabIndex = 10;
            this.BtnVentasDia.Text = "Ventas del Día";
            this.BtnVentasDia.UseVisualStyleBackColor = false;
            this.BtnVentasDia.Click += new System.EventHandler(this.BtnVentasDia_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.BtnVentasDia);
            this.Controls.Add(this.BtnProductosVendidos);
            this.Controls.Add(this.BtnExistenciaProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExistenciaProductos;
        private System.Windows.Forms.Button BtnProductosVendidos;
        private System.Windows.Forms.Button BtnVentasDia;
    }
}