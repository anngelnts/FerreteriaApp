using FerreteriaApp.Datos;
using FerreteriaApp.Entidades;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            //Iniciar Componentes de MaterialSkin
            var materialSkinManager = MaterialSkinManager.Instance;
            //Agregar de Interfaz FrmLogin : MaterialForm
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green500, Primary.Blue400, Accent.Blue700, TextShade.WHITE);
        }

        private void PbbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PbbMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;
        private void PanelControl_MouseMove(object sender, MouseEventArgs e)
        {
            MoverFormulario(e);
        }

        private void PanelBrand_MouseMove(object sender, MouseEventArgs e)
        {
            MoverFormulario(e);
        }

        private void MoverFormulario(MouseEventArgs e)
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("Ingrese Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUsername.Focus();
            }
            else if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Ingrese Contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPassword.Focus();
            }
            else
            {
                Login(TxtUsername.Text, TxtPassword.Text);
            }
        }
        private void Login(string Username, string Password)
        {
            DUsuario bo = new DUsuario();
            Usuario be = bo.LoginUsuario(Username, Password);
            if (be.Username != Username)
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (be.Password != Password)
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (be.Estado == 0)
            {
                MessageBox.Show("Usuario sin Acceso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Obtener ID del Empleado
                DEmpleado boEmpleado = new DEmpleado();
                int IDEmpleado = boEmpleado.ObtenerID(be.Username);
                FrmPrincipal.AccesoUsername = be.Username;
                FrmPrincipal.AccesoUsernameID = IDEmpleado;
                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                Hide();
            }
        }
    }
}
