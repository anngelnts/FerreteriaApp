namespace FerreteriaApp.Presentacion.Acciones
{
    partial class FrmProductoAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductoAE));
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.CbxSubCategoria = new System.Windows.Forms.ComboBox();
            this.CbxTipoExistencia = new System.Windows.Forms.ComboBox();
            this.CbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PtbImagen = new System.Windows.Forms.PictureBox();
            this.BtnUpImage = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRemoverImagen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(20, 55);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(370, 27);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.Leave += new System.EventHandler(this.TxtCodigo_Leave);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(20, 112);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(370, 27);
            this.TxtNombre.TabIndex = 1;
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.BackColor = System.Drawing.Color.White;
            this.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategoria.DropDownWidth = 270;
            this.CbxCategoria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.IntegralHeight = false;
            this.CbxCategoria.Location = new System.Drawing.Point(20, 170);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(370, 26);
            this.CbxCategoria.TabIndex = 2;
            this.CbxCategoria.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged);
            // 
            // CbxSubCategoria
            // 
            this.CbxSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSubCategoria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSubCategoria.FormattingEnabled = true;
            this.CbxSubCategoria.Location = new System.Drawing.Point(20, 229);
            this.CbxSubCategoria.Name = "CbxSubCategoria";
            this.CbxSubCategoria.Size = new System.Drawing.Size(370, 26);
            this.CbxSubCategoria.TabIndex = 3;
            // 
            // CbxTipoExistencia
            // 
            this.CbxTipoExistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoExistencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipoExistencia.FormattingEnabled = true;
            this.CbxTipoExistencia.Location = new System.Drawing.Point(20, 335);
            this.CbxTipoExistencia.Name = "CbxTipoExistencia";
            this.CbxTipoExistencia.Size = new System.Drawing.Size(370, 26);
            this.CbxTipoExistencia.TabIndex = 5;
            // 
            // CbxUnidadMedida
            // 
            this.CbxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUnidadMedida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxUnidadMedida.FormattingEnabled = true;
            this.CbxUnidadMedida.Location = new System.Drawing.Point(20, 387);
            this.CbxUnidadMedida.Name = "CbxUnidadMedida";
            this.CbxUnidadMedida.Size = new System.Drawing.Size(370, 26);
            this.CbxUnidadMedida.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sub Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de Existencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Unidad de Medida";
            // 
            // PtbImagen
            // 
            this.PtbImagen.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.thumbnail;
            this.PtbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PtbImagen.Location = new System.Drawing.Point(6, 17);
            this.PtbImagen.Name = "PtbImagen";
            this.PtbImagen.Size = new System.Drawing.Size(250, 250);
            this.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbImagen.TabIndex = 14;
            this.PtbImagen.TabStop = false;
            // 
            // BtnUpImage
            // 
            this.BtnUpImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(130)))), ((int)(((byte)(31)))));
            this.BtnUpImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpImage.FlatAppearance.BorderSize = 0;
            this.BtnUpImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpImage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpImage.ForeColor = System.Drawing.Color.White;
            this.BtnUpImage.Location = new System.Drawing.Point(6, 270);
            this.BtnUpImage.Name = "BtnUpImage";
            this.BtnUpImage.Size = new System.Drawing.Size(154, 35);
            this.BtnUpImage.TabIndex = 15;
            this.BtnUpImage.Text = "Cargar Imagen";
            this.BtnUpImage.UseVisualStyleBackColor = false;
            this.BtnUpImage.Click += new System.EventHandler(this.BtnUpImage_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(20, 432);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(150, 40);
            this.BtnGuardar.TabIndex = 22;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRemoverImagen);
            this.groupBox1.Controls.Add(this.PtbImagen);
            this.groupBox1.Controls.Add(this.BtnUpImage);
            this.groupBox1.Location = new System.Drawing.Point(401, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 312);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen";
            // 
            // BtnRemoverImagen
            // 
            this.BtnRemoverImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(81)))), ((int)(((byte)(69)))));
            this.BtnRemoverImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoverImagen.FlatAppearance.BorderSize = 0;
            this.BtnRemoverImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoverImagen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoverImagen.ForeColor = System.Drawing.Color.White;
            this.BtnRemoverImagen.Location = new System.Drawing.Point(166, 270);
            this.BtnRemoverImagen.Name = "BtnRemoverImagen";
            this.BtnRemoverImagen.Size = new System.Drawing.Size(90, 35);
            this.BtnRemoverImagen.TabIndex = 16;
            this.BtnRemoverImagen.Text = "Remover";
            this.BtnRemoverImagen.UseVisualStyleBackColor = false;
            this.BtnRemoverImagen.Click += new System.EventHandler(this.BtnRemoverImagen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Marca";
            // 
            // CbxMarca
            // 
            this.CbxMarca.BackColor = System.Drawing.Color.White;
            this.CbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMarca.DropDownWidth = 270;
            this.CbxMarca.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.IntegralHeight = false;
            this.CbxMarca.Location = new System.Drawing.Point(20, 283);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(370, 26);
            this.CbxMarca.TabIndex = 24;
            // 
            // FrmProductoAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(699, 484);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxMarca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxUnidadMedida);
            this.Controls.Add(this.CbxTipoExistencia);
            this.Controls.Add(this.CbxSubCategoria);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmProductoAE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FrmProductoAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnUpImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRemoverImagen;
        public System.Windows.Forms.TextBox TxtCodigo;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.ComboBox CbxCategoria;
        public System.Windows.Forms.ComboBox CbxSubCategoria;
        public System.Windows.Forms.ComboBox CbxTipoExistencia;
        public System.Windows.Forms.ComboBox CbxUnidadMedida;
        public System.Windows.Forms.ComboBox CbxMarca;
        public System.Windows.Forms.PictureBox PtbImagen;
        public System.Windows.Forms.Button BtnGuardar;
    }
}