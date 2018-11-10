using FerreteriaApp.Datos;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public static FrmPrincipal Main;
        public FrmPrincipal()
        {
            InitializeComponent();
            Main = this;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        public static string AccesoUsername;
        public static int AccesoUsernameID;

        public static double ValorUtilidad = 1.30;

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Dashboard");
            OpenForm(new FrmDashboard());
            FechaSistema();
            //Cargando datos
            CargarPerfilBasico();
        }

        public void CargarPerfilBasico()
        {
            DUsuario boUsuario = new DUsuario();
            if(boUsuario.ObtenerPerfilBasico(AccesoUsername) != null)
            {
                DataRow row = boUsuario.ObtenerPerfilBasico(AccesoUsername);
                LblUNombre.Text = row["Nombre"].ToString() + " " + row["Apellido"].ToString();
                LblUDescripcion.Text = row["Descripcion"].ToString();
            }
        }

        private void OpenForm(object formulario)
        {
            if(PanelContainer.Controls.Count > 0)
            {
                PanelContainer.Controls.RemoveAt(0);
            }
            Form frm = formulario as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Size = ClientSize;
            PanelContainer.Controls.Add(frm);
            PanelContainer.Tag = frm;
            frm.Show();
        }

        private void ChangeHeaderTitle(string title)
        {
            LblHeaderTitle.Text = title;
        }
        private void FechaSistema()
        {
            DateTime fm = DateTime.Now;
            LblFecha.Text = fm.ToLongDateString();
        }
        public void ChangeMessage(string message, string response)
        {
            LblMessage.Visible = true;
            switch (response)
            {
                case "Success":
                    PanelState.BackColor = Color.FromArgb(0, 230, 118);
                    LblMessage.ForeColor = Color.FromArgb(26, 26, 26);
                    break;
                case "Failed":
                    PanelState.BackColor = Color.FromArgb(229, 57, 53);
                    LblMessage.ForeColor = Color.White;
                    break;
                case "State":
                    PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.ForeColor = Color.Black;
                    break;
                default:
                    LblMessage.Visible = false;
                    PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.ForeColor = Color.Black;
                    break;
            }
            LblMessage.Text = message;
            Thread t = new Thread(new ThreadStart(MessageTheread));
            t.Start();
        }
        private void MessageTheread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(500);
                if (i == 9)
                {
                    MethodInvoker setM = () => LblMessage.Visible = false;
                    MethodInvoker setP = () => PanelState.BackColor = Color.FromArgb(191, 194, 199);
                    LblMessage.BeginInvoke(setM);
                    LblMessage.BeginInvoke(setP);
                }
            }
            
        }

        private void PbbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbbMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PbbMaximizar.Visible = false;
            PbbRestaurar.Visible = true;
        }

        private void PbbRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PbbMaximizar.Visible = true;
            PbbRestaurar.Visible = false;
        }

        private void PbbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;
        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        //Modulos
        private void BtnInicio_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Dashboard");
            OpenForm(new FrmDashboard());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Ventas");
            OpenForm(new FrmVentas());
        }

        private void PbbSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                Close();
            }
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Productos");
            OpenForm(new FrmProductos());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Clientes");
            OpenForm(new FrmClientes());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Compras");
            OpenForm(new FrmCompras());
        }

        private void BtnPersonal_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Personal");
            OpenForm(new FrmEmpleados());
        }

        private void PbbPerfil_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Perfil");
            OpenForm(new FrmPerfil());
        }

        private void BtnMovimientos_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Movimientos");
            OpenForm(new FrmMovimientos());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ChangeHeaderTitle("Reportes");
            OpenForm(new FrmReportes());
        }
    }
}
