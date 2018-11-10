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
    public partial class FrmClienteAE : Form
    {
        public FrmClienteAE()
        {
            InitializeComponent();
        }
        public static int modificar = 0;
        public static bool BtnGE = false;
        public static DateTime? fechnaci = DateTime.Now;

        private void FrmClienteAE_Load(object sender, EventArgs e)
        {
            CargarTipoDocumentoIdentidad();
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                MessageBox.Show("Digite Numero de Documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumeroDocumento.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Digite Nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (string.IsNullOrEmpty(TxtApellidos.Text))
            {
                MessageBox.Show("Digite Apellido del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            Cliente be = new Cliente
            {
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
            DCliente bo = new DCliente();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    FrmClientes frm = Owner as FrmClientes;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Cliente agregado correctamente", "Success");
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
                    FrmClientes frm = Owner as FrmClientes;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Cliente modificado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void CbxCumpleNull_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked )
            {
                DtpFechaNacimiento.Format = DateTimePickerFormat.Custom;
                DtpFechaNacimiento.CustomFormat = " ";
                DtpFechaNacimiento.Enabled = false;
            }
            else
            {
                DtpFechaNacimiento.Format = DateTimePickerFormat.Short;
                DtpFechaNacimiento.Text = DateTime.Now.ToString();
                DtpFechaNacimiento.Enabled = true;
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
                DCliente bo = new DCliente();
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
