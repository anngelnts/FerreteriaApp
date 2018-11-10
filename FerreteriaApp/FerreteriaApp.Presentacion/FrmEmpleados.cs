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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            DEmpleado bo = new DEmpleado();
            DgvPersonal.DataSource = bo.Listar();
        }

        private void Buscar(string KeyWoard)
        {
            DEmpleado bo = new DEmpleado();
            DgvPersonal.DataSource = bo.Buscar(KeyWoard);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmEmpleadoAE.modificar = 0;
            FrmEmpleadoAE frm = new FrmEmpleadoAE();
            AddOwnedForm(frm);
            frm.Text = "Nuevo Empleado";
            FrmEmpleadoAE.BtnGE = false;
            frm.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvPersonal.SelectedRows.Count > 0)
            {
                int rowindex = DgvPersonal.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        FrmEmpleadoAE.modificar = 1;
                        FrmEmpleadoAE frm = new FrmEmpleadoAE();
                        AddOwnedForm(frm);
                        frm.Text = "Modificar Empleado";
                        FrmEmpleadoAE.BtnGE = true;
                        FrmEmpleadoAE.cbxcargoselected = Convert.ToInt32(DgvPersonal.CurrentRow.Cells[0].Value);
                        frm.CbxTipoDocumento.Enabled = false;
                        frm.TxtNumeroDocumento.Enabled = false;
                        frm.TxtNumeroDocumento.Text = DgvPersonal.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtNombres.Text = DgvPersonal.CurrentRow.Cells[4].Value.ToString();
                        frm.TxtApellidos.Text = DgvPersonal.CurrentRow.Cells[5].Value.ToString();
                        if (DgvPersonal.CurrentRow.Cells[6].Value == DBNull.Value)
                        {
                            FrmEmpleadoAE.fechnaci = Convert.ToDateTime(DateTime.Now);
                        }
                        else
                        {
                            FrmEmpleadoAE.fechnaci = Convert.ToDateTime(DgvPersonal.CurrentRow.Cells[6].Value);
                        }
                        frm.TxtPais.Text = DgvPersonal.CurrentRow.Cells[7].Value.ToString();
                        frm.TxtCiudad.Text = DgvPersonal.CurrentRow.Cells[8].Value.ToString();
                        frm.TxtDireccion.Text = DgvPersonal.CurrentRow.Cells[9].Value.ToString();
                        frm.TxtEmail.Text = DgvPersonal.CurrentRow.Cells[10].Value.ToString();
                        frm.TxtTelefono.Text = DgvPersonal.CurrentRow.Cells[11].Value.ToString();
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

        private void BtnCargos_Click(object sender, EventArgs e)
        {
            FrmCargoAE frm = new FrmCargoAE();
            frm.ShowDialog();
        }
    }
}
