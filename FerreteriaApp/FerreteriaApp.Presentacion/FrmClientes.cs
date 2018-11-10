using FerreteriaApp.Datos;
using FerreteriaApp.Presentacion.Acciones;
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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmClienteAE.modificar = 0;
            FrmClienteAE frm = new FrmClienteAE();
            AddOwnedForm(frm);
            frm.Text = "Nuevo Cliente";
            FrmClienteAE.BtnGE = false;
            frm.ShowDialog();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            DCliente bo = new DCliente();
            DgvCiente.DataSource = bo.Listar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void Buscar()
        {
            DCliente bo = new DCliente();
            DgvCiente.DataSource = bo.Buscar(TxtBusqueda.Text);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvCiente.SelectedRows.Count > 0)
            {
                int rowindex = DgvCiente.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        FrmClienteAE.modificar = 1;
                        FrmClienteAE frm = new FrmClienteAE();
                        AddOwnedForm(frm);
                        frm.Text = "Modificar Cliente";
                        FrmClienteAE.BtnGE = true;
                        frm.CbxTipoDocumento.Enabled = false;
                        frm.TxtNumeroDocumento.Enabled = false;
                        frm.TxtNumeroDocumento.Text = DgvCiente.CurrentRow.Cells[2].Value.ToString();
                        frm.TxtNombres.Text = DgvCiente.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtApellidos.Text = DgvCiente.CurrentRow.Cells[4].Value.ToString();
                        if(DgvCiente.CurrentRow.Cells[5].Value == DBNull.Value)
                        {
                            FrmClienteAE.fechnaci = Convert.ToDateTime(DateTime.Now);
                        }
                        else
                        {
                            FrmClienteAE.fechnaci = Convert.ToDateTime(DgvCiente.CurrentRow.Cells[5].Value);
                        }
                        frm.TxtPais.Text = DgvCiente.CurrentRow.Cells[6].Value.ToString();
                        frm.TxtCiudad.Text = DgvCiente.CurrentRow.Cells[7].Value.ToString();
                        frm.TxtDireccion.Text = DgvCiente.CurrentRow.Cells[8].Value.ToString();
                        frm.TxtEmail.Text = DgvCiente.CurrentRow.Cells[9].Value.ToString();
                        frm.TxtTelefono.Text = DgvCiente.CurrentRow.Cells[10].Value.ToString();
                        frm.ShowDialog();
                    }
                    catch
                    {
                        //
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }
    }
}
