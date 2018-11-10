using FerreteriaApp.Datos;
using FerreteriaApp.Entidades;
using FerreteriaApp.Presentacion.Otros;
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
    public partial class FrmPerfil : Form
    {
        public FrmPerfil()
        {
            InitializeComponent();
        }

        private void BtnCambiarClave_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            ObtenerInformacion();
            HabilitarCampos(true);
        }

        private void ObtenerInformacion()
        {
            DEmpleado bo = new DEmpleado();
            if(bo.ObtenerInformacion(FrmPrincipal.AccesoUsername) == null)
            {
                //
            }
            else
            {
                DataRow row = bo.ObtenerInformacion(FrmPrincipal.AccesoUsername);
                TxtTipoDocumento.Text = row[0].ToString();
                TxtNumeroDocumento.Text = row[1].ToString();
                TxtCargo.Text = row[2].ToString();
                TxtNombres.Text = row[3].ToString();
                TxtApellidos.Text = row[4].ToString();
                DtpFechaNacimiento.Value = Convert.ToDateTime(row[5]);
                TxtPais.Text = row[6].ToString();
                TxtCiudad.Text = row[7].ToString();
                TxtDireccion.Text = row[8].ToString();
                TxtEmail.Text = row[9].ToString();
                TxtTelefono.Text = row[10].ToString();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = true;
        }
        private void HabilitarCampos(bool x)
        {
            TxtNombres.ReadOnly = x;
            TxtApellidos.ReadOnly = x;
            DtpFechaNacimiento.Enabled = !x;
            TxtPais.ReadOnly = x;
            TxtCiudad.ReadOnly = x;
            TxtDireccion.ReadOnly = x;
            TxtEmail.ReadOnly = x;
            TxtTelefono.ReadOnly = x;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Escriba su Nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (string.IsNullOrEmpty(TxtApellidos.Text))
            {
                MessageBox.Show("Escriba su Apellido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellidos.Focus();
            }
            else
            {
                GuardarCambios();
            }
        }
        private void GuardarCambios()
        {
            Empleado be = new Empleado
            {
                NumeroDocumento = FrmPrincipal.AccesoUsername,
                Nombre = TxtNombres.Text,
                Apellido = TxtApellidos.Text,
                FechaNacimiento = Convert.ToDateTime(DtpFechaNacimiento.Text),
                Pais = TxtPais.Text,
                Ciudad = TxtCiudad.Text,
                Direccion = TxtDireccion.Text,
                Email = TxtEmail.Text,
                Telefono = TxtTelefono.Text
            };
            DEmpleado bo = new DEmpleado();
            if(bo.ModificarxUsuario(be) == true)
            {
                FrmPrincipal.Main.ChangeMessage("Cambios realizados correctamente", "Success");
                BtnGuardar.Enabled = false;
                BtnModificar.Enabled = true;
                HabilitarCampos(true);
                FrmPrincipal.Main.CargarPerfilBasico();
            }
            else
            {
                FrmPrincipal.Main.ChangeMessage("No se pudo realizar cambios", "Failed");
            }
        }
    }
}
