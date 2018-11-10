namespace FerreteriaApp.Presentacion
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PanelBrand = new System.Windows.Forms.Panel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PanelControl = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtUsername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LblTituloControl = new System.Windows.Forms.Label();
            this.PbbMinimizar = new System.Windows.Forms.PictureBox();
            this.PbbCerrar = new System.Windows.Forms.PictureBox();
            this.PanelBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.PanelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelBrand
            // 
            this.PanelBrand.BackColor = System.Drawing.Color.White;
            this.PanelBrand.Controls.Add(this.PbLogo);
            this.PanelBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelBrand.Location = new System.Drawing.Point(0, 0);
            this.PanelBrand.Name = "PanelBrand";
            this.PanelBrand.Size = new System.Drawing.Size(400, 500);
            this.PanelBrand.TabIndex = 0;
            this.PanelBrand.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBrand_MouseMove);
            // 
            // PbLogo
            // 
            this.PbLogo.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.logo;
            this.PbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbLogo.Location = new System.Drawing.Point(25, 213);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(350, 75);
            this.PbLogo.TabIndex = 0;
            this.PbLogo.TabStop = false;
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PanelControl.Controls.Add(this.label3);
            this.PanelControl.Controls.Add(this.label2);
            this.PanelControl.Controls.Add(this.BtnLogin);
            this.PanelControl.Controls.Add(this.TxtPassword);
            this.PanelControl.Controls.Add(this.TxtUsername);
            this.PanelControl.Controls.Add(this.LblTituloControl);
            this.PanelControl.Controls.Add(this.PbbMinimizar);
            this.PanelControl.Controls.Add(this.PbbCerrar);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControl.Location = new System.Drawing.Point(400, 0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(400, 500);
            this.PanelControl.TabIndex = 1;
            this.PanelControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelControl_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(47, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(47, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Usuario";
            // 
            // BtnLogin
            // 
            this.BtnLogin.AutoSize = true;
            this.BtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Depth = 0;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogin.Icon = null;
            this.BtnLogin.Location = new System.Drawing.Point(230, 352);
            this.BtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Primary = true;
            this.BtnLogin.Size = new System.Drawing.Size(120, 36);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Iniciar Sesión";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Depth = 0;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Hint = "";
            this.TxtPassword.Location = new System.Drawing.Point(50, 288);
            this.TxtPassword.MaxLength = 32767;
            this.TxtPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.SelectionLength = 0;
            this.TxtPassword.SelectionStart = 0;
            this.TxtPassword.Size = new System.Drawing.Size(300, 23);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.UseSystemPasswordChar = false;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Depth = 0;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Hint = "";
            this.TxtUsername.Location = new System.Drawing.Point(50, 200);
            this.TxtUsername.MaxLength = 32767;
            this.TxtUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PasswordChar = '\0';
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.SelectionLength = 0;
            this.TxtUsername.SelectionStart = 0;
            this.TxtUsername.Size = new System.Drawing.Size(300, 23);
            this.TxtUsername.TabIndex = 3;
            this.TxtUsername.TabStop = false;
            this.TxtUsername.UseSystemPasswordChar = false;
            // 
            // LblTituloControl
            // 
            this.LblTituloControl.AutoSize = true;
            this.LblTituloControl.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloControl.ForeColor = System.Drawing.Color.Silver;
            this.LblTituloControl.Location = new System.Drawing.Point(28, 86);
            this.LblTituloControl.Name = "LblTituloControl";
            this.LblTituloControl.Size = new System.Drawing.Size(248, 25);
            this.LblTituloControl.TabIndex = 2;
            this.LblTituloControl.Text = "Ingrese a su Cuenta";
            // 
            // PbbMinimizar
            // 
            this.PbbMinimizar.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_minimizar_light;
            this.PbbMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbMinimizar.Location = new System.Drawing.Point(335, 3);
            this.PbbMinimizar.Name = "PbbMinimizar";
            this.PbbMinimizar.Size = new System.Drawing.Size(30, 30);
            this.PbbMinimizar.TabIndex = 1;
            this.PbbMinimizar.TabStop = false;
            this.PbbMinimizar.Click += new System.EventHandler(this.PbbMinimizar_Click);
            // 
            // PbbCerrar
            // 
            this.PbbCerrar.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_cerrar_light;
            this.PbbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbCerrar.Location = new System.Drawing.Point(367, 3);
            this.PbbCerrar.Name = "PbbCerrar";
            this.PbbCerrar.Size = new System.Drawing.Size(30, 30);
            this.PbbCerrar.TabIndex = 0;
            this.PbbCerrar.TabStop = false;
            this.PbbCerrar.Click += new System.EventHandler(this.PbbCerrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelBrand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.PanelBrand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.PanelControl.ResumeLayout(false);
            this.PanelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelBrand;
        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.PictureBox PbbCerrar;
        private System.Windows.Forms.PictureBox PbbMinimizar;
        private System.Windows.Forms.Label LblTituloControl;
        private System.Windows.Forms.PictureBox PbLogo;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtUsername;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPassword;
        private MaterialSkin.Controls.MaterialRaisedButton BtnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

