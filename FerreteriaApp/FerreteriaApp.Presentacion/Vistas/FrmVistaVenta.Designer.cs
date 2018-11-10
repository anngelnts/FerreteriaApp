namespace FerreteriaApp.Presentacion.Vistas
{
    partial class FrmVistaVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVistaVenta));
            this.GbxResumen = new System.Windows.Forms.GroupBox();
            this.RLblTotal = new System.Windows.Forms.Label();
            this.RLblIgv = new System.Windows.Forms.Label();
            this.RLblSubTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GbxDetalle = new System.Windows.Forms.GroupBox();
            this.MLVDetalle = new MaterialSkin.Controls.MaterialListView();
            this.GbxCliente = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.GbxComprobante = new System.Windows.Forms.GroupBox();
            this.TxtTipoComprobante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFechaEmision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbxAcciones = new System.Windows.Forms.GroupBox();
            this.GbxInfoEmpleado = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNEmpleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNDEmpleado = new System.Windows.Forms.TextBox();
            this.GbxResumen.SuspendLayout();
            this.GbxDetalle.SuspendLayout();
            this.GbxCliente.SuspendLayout();
            this.GbxComprobante.SuspendLayout();
            this.GbxInfoEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxResumen
            // 
            this.GbxResumen.Controls.Add(this.RLblTotal);
            this.GbxResumen.Controls.Add(this.RLblIgv);
            this.GbxResumen.Controls.Add(this.RLblSubTotal);
            this.GbxResumen.Controls.Add(this.label10);
            this.GbxResumen.Controls.Add(this.label9);
            this.GbxResumen.Controls.Add(this.label8);
            this.GbxResumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxResumen.Location = new System.Drawing.Point(490, 440);
            this.GbxResumen.Name = "GbxResumen";
            this.GbxResumen.Size = new System.Drawing.Size(282, 100);
            this.GbxResumen.TabIndex = 9;
            this.GbxResumen.TabStop = false;
            this.GbxResumen.Text = "Resumen";
            // 
            // RLblTotal
            // 
            this.RLblTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.RLblTotal.Location = new System.Drawing.Point(110, 73);
            this.RLblTotal.Name = "RLblTotal";
            this.RLblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RLblTotal.Size = new System.Drawing.Size(161, 16);
            this.RLblTotal.TabIndex = 5;
            this.RLblTotal.Text = "S/. 00.00";
            // 
            // RLblIgv
            // 
            this.RLblIgv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLblIgv.Location = new System.Drawing.Point(109, 48);
            this.RLblIgv.Name = "RLblIgv";
            this.RLblIgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RLblIgv.Size = new System.Drawing.Size(162, 13);
            this.RLblIgv.TabIndex = 4;
            this.RLblIgv.Text = "S/. 00.00";
            // 
            // RLblSubTotal
            // 
            this.RLblSubTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLblSubTotal.Location = new System.Drawing.Point(119, 22);
            this.RLblSubTotal.Name = "RLblSubTotal";
            this.RLblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RLblSubTotal.Size = new System.Drawing.Size(152, 13);
            this.RLblSubTotal.TabIndex = 3;
            this.RLblSubTotal.Text = "S/. 00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "IGV: (18%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sub Total:";
            // 
            // GbxDetalle
            // 
            this.GbxDetalle.Controls.Add(this.MLVDetalle);
            this.GbxDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxDetalle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxDetalle.Location = new System.Drawing.Point(12, 234);
            this.GbxDetalle.Name = "GbxDetalle";
            this.GbxDetalle.Size = new System.Drawing.Size(760, 200);
            this.GbxDetalle.TabIndex = 8;
            this.GbxDetalle.TabStop = false;
            this.GbxDetalle.Text = "Detalle del documento";
            // 
            // MLVDetalle
            // 
            this.MLVDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MLVDetalle.Depth = 0;
            this.MLVDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MLVDetalle.FullRowSelect = true;
            this.MLVDetalle.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.MLVDetalle.Location = new System.Drawing.Point(6, 20);
            this.MLVDetalle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MLVDetalle.MouseState = MaterialSkin.MouseState.OUT;
            this.MLVDetalle.Name = "MLVDetalle";
            this.MLVDetalle.OwnerDraw = true;
            this.MLVDetalle.Size = new System.Drawing.Size(748, 174);
            this.MLVDetalle.TabIndex = 0;
            this.MLVDetalle.UseCompatibleStateImageBehavior = false;
            this.MLVDetalle.View = System.Windows.Forms.View.Details;
            // 
            // GbxCliente
            // 
            this.GbxCliente.Controls.Add(this.label7);
            this.GbxCliente.Controls.Add(this.TxtDireccion);
            this.GbxCliente.Controls.Add(this.label6);
            this.GbxCliente.Controls.Add(this.TxtNombres);
            this.GbxCliente.Controls.Add(this.label5);
            this.GbxCliente.Controls.Add(this.TxtNumeroDocumento);
            this.GbxCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCliente.Location = new System.Drawing.Point(12, 98);
            this.GbxCliente.Name = "GbxCliente";
            this.GbxCliente.Size = new System.Drawing.Size(550, 130);
            this.GbxCliente.TabIndex = 7;
            this.GbxCliente.TabStop = false;
            this.GbxCliente.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dirección";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.TxtDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(18, 90);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(512, 27);
            this.TxtDireccion.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(185, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombres";
            // 
            // TxtNombres
            // 
            this.TxtNombres.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNombres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(188, 37);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.ReadOnly = true;
            this.TxtNombres.Size = new System.Drawing.Size(342, 27);
            this.TxtNombres.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número Documento";
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(18, 37);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.ReadOnly = true;
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(164, 27);
            this.TxtNumeroDocumento.TabIndex = 14;
            // 
            // GbxComprobante
            // 
            this.GbxComprobante.Controls.Add(this.TxtTipoComprobante);
            this.GbxComprobante.Controls.Add(this.label4);
            this.GbxComprobante.Controls.Add(this.TxtFechaEmision);
            this.GbxComprobante.Controls.Add(this.label3);
            this.GbxComprobante.Controls.Add(this.TxtNumero);
            this.GbxComprobante.Controls.Add(this.label2);
            this.GbxComprobante.Controls.Add(this.TxtSerie);
            this.GbxComprobante.Controls.Add(this.label1);
            this.GbxComprobante.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxComprobante.Location = new System.Drawing.Point(12, 12);
            this.GbxComprobante.Name = "GbxComprobante";
            this.GbxComprobante.Size = new System.Drawing.Size(550, 80);
            this.GbxComprobante.TabIndex = 6;
            this.GbxComprobante.TabStop = false;
            this.GbxComprobante.Text = "Comprobante";
            // 
            // TxtTipoComprobante
            // 
            this.TxtTipoComprobante.BackColor = System.Drawing.SystemColors.Control;
            this.TxtTipoComprobante.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoComprobante.Location = new System.Drawing.Point(18, 37);
            this.TxtTipoComprobante.Name = "TxtTipoComprobante";
            this.TxtTipoComprobante.ReadOnly = true;
            this.TxtTipoComprobante.Size = new System.Drawing.Size(164, 27);
            this.TxtTipoComprobante.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha";
            // 
            // TxtFechaEmision
            // 
            this.TxtFechaEmision.BackColor = System.Drawing.SystemColors.Control;
            this.TxtFechaEmision.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaEmision.Location = new System.Drawing.Point(410, 37);
            this.TxtFechaEmision.Name = "TxtFechaEmision";
            this.TxtFechaEmision.ReadOnly = true;
            this.TxtFechaEmision.Size = new System.Drawing.Size(120, 27);
            this.TxtFechaEmision.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNumero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(264, 37);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.ReadOnly = true;
            this.TxtNumero.Size = new System.Drawing.Size(140, 27);
            this.TxtNumero.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Serie";
            // 
            // TxtSerie
            // 
            this.TxtSerie.BackColor = System.Drawing.SystemColors.Control;
            this.TxtSerie.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerie.Location = new System.Drawing.Point(188, 37);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.ReadOnly = true;
            this.TxtSerie.Size = new System.Drawing.Size(70, 27);
            this.TxtSerie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo de comprobante";
            // 
            // GbxAcciones
            // 
            this.GbxAcciones.Location = new System.Drawing.Point(572, 12);
            this.GbxAcciones.Name = "GbxAcciones";
            this.GbxAcciones.Size = new System.Drawing.Size(200, 216);
            this.GbxAcciones.TabIndex = 10;
            this.GbxAcciones.TabStop = false;
            this.GbxAcciones.Text = "Acciones";
            // 
            // GbxInfoEmpleado
            // 
            this.GbxInfoEmpleado.Controls.Add(this.label12);
            this.GbxInfoEmpleado.Controls.Add(this.TxtNEmpleado);
            this.GbxInfoEmpleado.Controls.Add(this.label11);
            this.GbxInfoEmpleado.Controls.Add(this.TxtNDEmpleado);
            this.GbxInfoEmpleado.Location = new System.Drawing.Point(12, 440);
            this.GbxInfoEmpleado.Name = "GbxInfoEmpleado";
            this.GbxInfoEmpleado.Size = new System.Drawing.Size(472, 100);
            this.GbxInfoEmpleado.TabIndex = 11;
            this.GbxInfoEmpleado.TabStop = false;
            this.GbxInfoEmpleado.Text = "Venta realizada por";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Nombre";
            // 
            // TxtNEmpleado
            // 
            this.TxtNEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNEmpleado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNEmpleado.Location = new System.Drawing.Point(18, 70);
            this.TxtNEmpleado.Name = "TxtNEmpleado";
            this.TxtNEmpleado.ReadOnly = true;
            this.TxtNEmpleado.Size = new System.Drawing.Size(437, 21);
            this.TxtNEmpleado.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Número Documento";
            // 
            // TxtNDEmpleado
            // 
            this.TxtNDEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNDEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNDEmpleado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNDEmpleado.Location = new System.Drawing.Point(18, 33);
            this.TxtNDEmpleado.Name = "TxtNDEmpleado";
            this.TxtNDEmpleado.ReadOnly = true;
            this.TxtNDEmpleado.Size = new System.Drawing.Size(164, 21);
            this.TxtNDEmpleado.TabIndex = 20;
            // 
            // FrmVistaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GbxInfoEmpleado);
            this.Controls.Add(this.GbxAcciones);
            this.Controls.Add(this.GbxResumen);
            this.Controls.Add(this.GbxDetalle);
            this.Controls.Add(this.GbxCliente);
            this.Controls.Add(this.GbxComprobante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVistaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FrmVistaVenta_Load);
            this.GbxResumen.ResumeLayout(false);
            this.GbxResumen.PerformLayout();
            this.GbxDetalle.ResumeLayout(false);
            this.GbxCliente.ResumeLayout(false);
            this.GbxCliente.PerformLayout();
            this.GbxComprobante.ResumeLayout(false);
            this.GbxComprobante.PerformLayout();
            this.GbxInfoEmpleado.ResumeLayout(false);
            this.GbxInfoEmpleado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxResumen;
        private System.Windows.Forms.Label RLblTotal;
        private System.Windows.Forms.Label RLblIgv;
        private System.Windows.Forms.Label RLblSubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GbxDetalle;
        private MaterialSkin.Controls.MaterialListView MLVDetalle;
        private System.Windows.Forms.GroupBox GbxCliente;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.GroupBox GbxComprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFechaEmision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbxAcciones;
        private System.Windows.Forms.TextBox TxtTipoComprobante;
        private System.Windows.Forms.GroupBox GbxInfoEmpleado;
        public System.Windows.Forms.TextBox TxtNDEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox TxtNEmpleado;
    }
}