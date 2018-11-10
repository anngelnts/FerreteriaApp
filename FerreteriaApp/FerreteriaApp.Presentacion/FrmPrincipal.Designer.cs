namespace FerreteriaApp.Presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.PbbMaximizar = new System.Windows.Forms.PictureBox();
            this.PbbRestaurar = new System.Windows.Forms.PictureBox();
            this.PbbMinimizar = new System.Windows.Forms.PictureBox();
            this.PbbCerrar = new System.Windows.Forms.PictureBox();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelNavegacion = new System.Windows.Forms.Panel();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnMovimientos = new System.Windows.Forms.Button();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnCompras = new System.Windows.Forms.Button();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelProfile = new System.Windows.Forms.Panel();
            this.PbbSalir = new System.Windows.Forms.PictureBox();
            this.PbbPerfil = new System.Windows.Forms.PictureBox();
            this.PbbConfiguracion = new System.Windows.Forms.PictureBox();
            this.LblUDescripcion = new System.Windows.Forms.Label();
            this.LblUNombre = new System.Windows.Forms.Label();
            this.PbxUFoto = new System.Windows.Forms.PictureBox();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHeaderTitle = new System.Windows.Forms.Label();
            this.PanelState = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).BeginInit();
            this.PanelLeft.SuspendLayout();
            this.PanelNavegacion.SuspendLayout();
            this.PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUFoto)).BeginInit();
            this.PanelHeader.SuspendLayout();
            this.PanelState.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Black;
            this.PanelTop.Controls.Add(this.PbLogo);
            this.PanelTop.Controls.Add(this.PbbMaximizar);
            this.PanelTop.Controls.Add(this.PbbRestaurar);
            this.PanelTop.Controls.Add(this.PbbMinimizar);
            this.PanelTop.Controls.Add(this.PbbCerrar);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1300, 45);
            this.PanelTop.TabIndex = 0;
            this.PanelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            // 
            // PbLogo
            // 
            this.PbLogo.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.logo;
            this.PbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbLogo.Location = new System.Drawing.Point(10, 5);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(172, 35);
            this.PbLogo.TabIndex = 4;
            this.PbLogo.TabStop = false;
            // 
            // PbbMaximizar
            // 
            this.PbbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbMaximizar.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_maximizar_light;
            this.PbbMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbMaximizar.Location = new System.Drawing.Point(1221, 5);
            this.PbbMaximizar.Name = "PbbMaximizar";
            this.PbbMaximizar.Size = new System.Drawing.Size(35, 35);
            this.PbbMaximizar.TabIndex = 1;
            this.PbbMaximizar.TabStop = false;
            this.PbbMaximizar.Click += new System.EventHandler(this.PbbMaximizar_Click);
            // 
            // PbbRestaurar
            // 
            this.PbbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbRestaurar.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_restaurar_light;
            this.PbbRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbRestaurar.Location = new System.Drawing.Point(1221, 5);
            this.PbbRestaurar.Name = "PbbRestaurar";
            this.PbbRestaurar.Size = new System.Drawing.Size(35, 35);
            this.PbbRestaurar.TabIndex = 2;
            this.PbbRestaurar.TabStop = false;
            this.PbbRestaurar.Click += new System.EventHandler(this.PbbRestaurar_Click);
            // 
            // PbbMinimizar
            // 
            this.PbbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbMinimizar.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_minimizar_light;
            this.PbbMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbMinimizar.Location = new System.Drawing.Point(1183, 5);
            this.PbbMinimizar.Name = "PbbMinimizar";
            this.PbbMinimizar.Size = new System.Drawing.Size(35, 35);
            this.PbbMinimizar.TabIndex = 3;
            this.PbbMinimizar.TabStop = false;
            this.PbbMinimizar.Click += new System.EventHandler(this.PbbMinimizar_Click);
            // 
            // PbbCerrar
            // 
            this.PbbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbCerrar.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_cerrar_light;
            this.PbbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbCerrar.Location = new System.Drawing.Point(1259, 5);
            this.PbbCerrar.Name = "PbbCerrar";
            this.PbbCerrar.Size = new System.Drawing.Size(35, 35);
            this.PbbCerrar.TabIndex = 0;
            this.PbbCerrar.TabStop = false;
            this.PbbCerrar.Click += new System.EventHandler(this.PbbCerrar_Click);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.PanelLeft.Controls.Add(this.PanelNavegacion);
            this.PanelLeft.Controls.Add(this.PanelProfile);
            this.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft.Location = new System.Drawing.Point(0, 45);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(250, 655);
            this.PanelLeft.TabIndex = 1;
            // 
            // PanelNavegacion
            // 
            this.PanelNavegacion.Controls.Add(this.BtnReportes);
            this.PanelNavegacion.Controls.Add(this.BtnMovimientos);
            this.PanelNavegacion.Controls.Add(this.BtnPersonal);
            this.PanelNavegacion.Controls.Add(this.BtnClientes);
            this.PanelNavegacion.Controls.Add(this.BtnProductos);
            this.PanelNavegacion.Controls.Add(this.BtnCompras);
            this.PanelNavegacion.Controls.Add(this.BtnVentas);
            this.PanelNavegacion.Controls.Add(this.BtnInicio);
            this.PanelNavegacion.Controls.Add(this.label4);
            this.PanelNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNavegacion.Location = new System.Drawing.Point(0, 130);
            this.PanelNavegacion.Name = "PanelNavegacion";
            this.PanelNavegacion.Size = new System.Drawing.Size(250, 525);
            this.PanelNavegacion.TabIndex = 1;
            // 
            // BtnReportes
            // 
            this.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Image = global::FerreteriaApp.Presentacion.Properties.Resources.icon_informe_xs_light;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(0, 432);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnReportes.Size = new System.Drawing.Size(250, 50);
            this.BtnReportes.TabIndex = 11;
            this.BtnReportes.Text = "  Reportes";
            this.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnMovimientos
            // 
            this.BtnMovimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMovimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnMovimientos.FlatAppearance.BorderSize = 0;
            this.BtnMovimientos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMovimientos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovimientos.ForeColor = System.Drawing.Color.White;
            this.BtnMovimientos.Image = global::FerreteriaApp.Presentacion.Properties.Resources.icon_movimientos_xs_light;
            this.BtnMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMovimientos.Location = new System.Drawing.Point(0, 376);
            this.BtnMovimientos.Name = "BtnMovimientos";
            this.BtnMovimientos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnMovimientos.Size = new System.Drawing.Size(250, 50);
            this.BtnMovimientos.TabIndex = 10;
            this.BtnMovimientos.Text = "  Movimientos";
            this.BtnMovimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMovimientos.UseVisualStyleBackColor = true;
            this.BtnMovimientos.Click += new System.EventHandler(this.BtnMovimientos_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPersonal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.ForeColor = System.Drawing.Color.White;
            this.BtnPersonal.Image = global::FerreteriaApp.Presentacion.Properties.Resources.icon_empleado_xs_light;
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.Location = new System.Drawing.Point(0, 320);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnPersonal.Size = new System.Drawing.Size(250, 50);
            this.BtnPersonal.TabIndex = 9;
            this.BtnPersonal.Text = "  Personal";
            this.BtnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.BtnPersonal_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.Image = global::FerreteriaApp.Presentacion.Properties.Resources.icon_clientes_xs_light;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 264);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnClientes.Size = new System.Drawing.Size(250, 50);
            this.BtnClientes.TabIndex = 8;
            this.BtnClientes.Text = "  Clientes";
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.Color.White;
            this.BtnProductos.Image = global::FerreteriaApp.Presentacion.Properties.Resources.icon_xs_producto_light;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(0, 208);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnProductos.Size = new System.Drawing.Size(250, 50);
            this.BtnProductos.TabIndex = 7;
            this.BtnProductos.Text = "  Productos";
            this.BtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnCompras
            // 
            this.BtnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnCompras.FlatAppearance.BorderSize = 0;
            this.BtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompras.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompras.ForeColor = System.Drawing.Color.White;
            this.BtnCompras.Image = global::FerreteriaApp.Presentacion.Properties.Resources.icon_xs_compras_light;
            this.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.Location = new System.Drawing.Point(0, 152);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCompras.Size = new System.Drawing.Size(250, 50);
            this.BtnCompras.TabIndex = 6;
            this.BtnCompras.Text = "  Compras";
            this.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompras.UseVisualStyleBackColor = true;
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.White;
            this.BtnVentas.Image = global::FerreteriaApp.Presentacion.Properties.Resources.icon_xs_checkout_light;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(0, 96);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnVentas.Size = new System.Drawing.Size(250, 50);
            this.BtnVentas.TabIndex = 5;
            this.BtnVentas.Text = "  Ventas";
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.White;
            this.BtnInicio.Image = global::FerreteriaApp.Presentacion.Properties.Resources.icon_xs_home_light;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 40);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnInicio.Size = new System.Drawing.Size(250, 50);
            this.BtnInicio.TabIndex = 4;
            this.BtnInicio.Text = "  Inicio";
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAVEGACIÓN PRINCIPAL";
            // 
            // PanelProfile
            // 
            this.PanelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.PanelProfile.Controls.Add(this.PbbSalir);
            this.PanelProfile.Controls.Add(this.PbbPerfil);
            this.PanelProfile.Controls.Add(this.PbbConfiguracion);
            this.PanelProfile.Controls.Add(this.LblUDescripcion);
            this.PanelProfile.Controls.Add(this.LblUNombre);
            this.PanelProfile.Controls.Add(this.PbxUFoto);
            this.PanelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProfile.Location = new System.Drawing.Point(0, 0);
            this.PanelProfile.Name = "PanelProfile";
            this.PanelProfile.Size = new System.Drawing.Size(250, 130);
            this.PanelProfile.TabIndex = 0;
            // 
            // PbbSalir
            // 
            this.PbbSalir.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_salir_light;
            this.PbbSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbSalir.Location = new System.Drawing.Point(165, 96);
            this.PbbSalir.Name = "PbbSalir";
            this.PbbSalir.Size = new System.Drawing.Size(25, 25);
            this.PbbSalir.TabIndex = 5;
            this.PbbSalir.TabStop = false;
            this.PbbSalir.Click += new System.EventHandler(this.PbbSalir_Click);
            // 
            // PbbPerfil
            // 
            this.PbbPerfil.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_user_light;
            this.PbbPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbPerfil.Location = new System.Drawing.Point(113, 96);
            this.PbbPerfil.Name = "PbbPerfil";
            this.PbbPerfil.Size = new System.Drawing.Size(25, 25);
            this.PbbPerfil.TabIndex = 4;
            this.PbbPerfil.TabStop = false;
            this.PbbPerfil.Click += new System.EventHandler(this.PbbPerfil_Click);
            // 
            // PbbConfiguracion
            // 
            this.PbbConfiguracion.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.icon_setting_light;
            this.PbbConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbConfiguracion.Location = new System.Drawing.Point(62, 96);
            this.PbbConfiguracion.Name = "PbbConfiguracion";
            this.PbbConfiguracion.Size = new System.Drawing.Size(25, 25);
            this.PbbConfiguracion.TabIndex = 3;
            this.PbbConfiguracion.TabStop = false;
            // 
            // LblUDescripcion
            // 
            this.LblUDescripcion.AutoSize = true;
            this.LblUDescripcion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.LblUDescripcion.Location = new System.Drawing.Point(78, 48);
            this.LblUDescripcion.Name = "LblUDescripcion";
            this.LblUDescripcion.Size = new System.Drawing.Size(111, 18);
            this.LblUDescripcion.TabIndex = 2;
            this.LblUDescripcion.Text = "Administrador";
            // 
            // LblUNombre
            // 
            this.LblUNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUNombre.ForeColor = System.Drawing.Color.White;
            this.LblUNombre.Location = new System.Drawing.Point(78, 24);
            this.LblUNombre.Name = "LblUNombre";
            this.LblUNombre.Size = new System.Drawing.Size(158, 18);
            this.LblUNombre.TabIndex = 1;
            this.LblUNombre.Text = "Luis Angel Moreno";
            // 
            // PbxUFoto
            // 
            this.PbxUFoto.BackgroundImage = global::FerreteriaApp.Presentacion.Properties.Resources.profile;
            this.PbxUFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxUFoto.Location = new System.Drawing.Point(12, 15);
            this.PbxUFoto.Name = "PbxUFoto";
            this.PbxUFoto.Size = new System.Drawing.Size(60, 60);
            this.PbxUFoto.TabIndex = 0;
            this.PbxUFoto.TabStop = false;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.White;
            this.PanelHeader.Controls.Add(this.LblFecha);
            this.PanelHeader.Controls.Add(this.LblHeaderTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(250, 45);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1050, 50);
            this.PanelHeader.TabIndex = 2;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(671, 14);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblFecha.Size = new System.Drawing.Size(367, 18);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Sábado, 27 de Octubre del 2018";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHeaderTitle
            // 
            this.LblHeaderTitle.AutoSize = true;
            this.LblHeaderTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
            this.LblHeaderTitle.Location = new System.Drawing.Point(16, 14);
            this.LblHeaderTitle.Name = "LblHeaderTitle";
            this.LblHeaderTitle.Size = new System.Drawing.Size(125, 23);
            this.LblHeaderTitle.TabIndex = 0;
            this.LblHeaderTitle.Text = "Dashboard";
            // 
            // PanelState
            // 
            this.PanelState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.PanelState.Controls.Add(this.LblMessage);
            this.PanelState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelState.Location = new System.Drawing.Point(250, 660);
            this.PanelState.Name = "PanelState";
            this.PanelState.Size = new System.Drawing.Size(1050, 40);
            this.PanelState.TabIndex = 3;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(17, 11);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(26, 18);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "...";
            this.LblMessage.Visible = false;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(250, 95);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1050, 565);
            this.PanelContainer.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelState);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferreteria Martín";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).EndInit();
            this.PanelLeft.ResumeLayout(false);
            this.PanelNavegacion.ResumeLayout(false);
            this.PanelNavegacion.PerformLayout();
            this.PanelProfile.ResumeLayout(false);
            this.PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUFoto)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelState.ResumeLayout(false);
            this.PanelState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel PanelState;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.PictureBox PbbCerrar;
        private System.Windows.Forms.PictureBox PbbRestaurar;
        private System.Windows.Forms.PictureBox PbbMaximizar;
        private System.Windows.Forms.PictureBox PbbMinimizar;
        private System.Windows.Forms.Label LblHeaderTitle;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel PanelProfile;
        private System.Windows.Forms.PictureBox PbxUFoto;
        private System.Windows.Forms.Label LblUDescripcion;
        private System.Windows.Forms.Label LblUNombre;
        private System.Windows.Forms.PictureBox PbbConfiguracion;
        private System.Windows.Forms.PictureBox PbbSalir;
        private System.Windows.Forms.PictureBox PbbPerfil;
        private System.Windows.Forms.Panel PanelNavegacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnMovimientos;
        private System.Windows.Forms.Button BtnPersonal;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnCompras;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.PictureBox PbLogo;
    }
}