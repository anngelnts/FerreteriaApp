using FerreteriaApp.Datos;
using FerreteriaApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Presentacion.Acciones
{
    public partial class FrmEmpleadoAE : Form
    {
        public FrmEmpleadoAE()
        {
            InitializeComponent();
        }

        public static int modificar = 0;
        public static bool BtnGE = false;
        public static DateTime? fechnaci = DateTime.Now;
        public static int cbxcargoselected = 0;

        private void FrmEmpleadoAE_Load(object sender, EventArgs e)
        {
            CargarTipoDocumentoIdentidad();
            CargarCargo();
            //attr
            DtpFechaNacimiento.Text = fechnaci.ToString();
            BtnGuardar.Enabled = BtnGE;
        }

        private void CargarTipoDocumentoIdentidad()
        {
            DTipoDocumentoIdentidad bo = new DTipoDocumentoIdentidad();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxTipoDocumento.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxTipoDocumento.ValueMember = "Key";
                CbxTipoDocumento.DisplayMember = "Value";
            }
            CbxTipoDocumento.SelectedValue = "1";
        }
        private void CargarCargo()
        {
            DCargo bo = new DCargo();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxCargo.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxCargo.ValueMember = "Key";
                CbxCargo.DisplayMember = "Value";
            }
            if(cbxcargoselected != 0)
            {
                CbxCargo.SelectedValue = cbxcargoselected;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                MessageBox.Show("Digite Numero de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumeroDocumento.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Digite Nombre del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (string.IsNullOrEmpty(TxtApellidos.Text))
            {
                MessageBox.Show("Digite Apellido del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellidos.Focus();
            }
            else if (string.IsNullOrEmpty(CbxCargo.Text))
            {
                MessageBox.Show("Seleccione Cargo del empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtApellidos.Focus();
            }
            else
            {
                Guardar();
            }
        }

        private void Guardar()
        {
            DateTime? fechnac = string.IsNullOrWhiteSpace(DtpFechaNacimiento.Text) ? (DateTime?)null : Convert.ToDateTime(DtpFechaNacimiento.Text);
            Empleado be = new Empleado
            {
                Cargo = Convert.ToInt32(CbxCargo.SelectedValue),
                TipoDocumento = CbxTipoDocumento.SelectedValue.ToString(),
                NumeroDocumento = TxtNumeroDocumento.Text,
                Nombre = TxtNombres.Text,
                Apellido = TxtApellidos.Text,
                FechaNacimiento = fechnac,
                Pais = TxtPais.Text,
                Ciudad = TxtCiudad.Text,
                Direccion = TxtDireccion.Text,
                Email = TxtEmail.Text,
                Telefono = TxtTelefono.Text,
                Estado = 1
            };
            DEmpleado bo = new DEmpleado();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    FrmEmpleados frm = Owner as FrmEmpleados;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Empleado agregado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
            else if (modificar == 1)
            {
                if (bo.Modificar(be))
                {
                    FrmEmpleados frm = Owner as FrmEmpleados;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Empleado modificado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void TxtNumeroDocumento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                BtnGuardar.Enabled = false;
                TxtNumeroDocumento.Focus();
            }
            else
            {
                DEmpleado bo = new DEmpleado();
                if (bo.VerificarNumeroDocumento(TxtNumeroDocumento.Text))
                {
                    BtnGuardar.Enabled = true;
                    TxtNumeroDocumento.BackColor = Color.FromArgb(126, 225, 154);
                }
                else
                {
                    BtnGuardar.Enabled = false;
                    TxtNumeroDocumento.BackColor = Color.FromArgb(241, 115, 117);
                    TxtNumeroDocumento.Focus();
                }
            }
        }
    }
}
