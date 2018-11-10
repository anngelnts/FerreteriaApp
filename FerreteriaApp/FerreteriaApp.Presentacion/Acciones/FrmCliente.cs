using FerreteriaApp.Datos;
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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            DCliente bo = new DCliente();
            DgvCliente.DataSource = bo.Listar();
        }
        private void Buscar(string KeyWoard)
        {
            DCliente bo = new DCliente();
            DgvCliente.DataSource = bo.Buscar(KeyWoard);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvCliente.SelectedRows.Count > 0)
            {
                int rowindex = DgvCliente.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        FrmVenta frm = Owner as FrmVenta;
                        frm.LblIDCliente.Text = DgvCliente.CurrentRow.Cells[0].Value.ToString();
                        frm.TxtNumeroDocumento.Text = DgvCliente.CurrentRow.Cells[2].Value.ToString();
                        frm.TxtNombres.Text = DgvCliente.CurrentRow.Cells[3].Value.ToString() + " " + DgvCliente.CurrentRow.Cells[4].Value.ToString();
                        string direccion = DgvCliente.CurrentRow.Cells[8].Value.ToString() + ", " + DgvCliente.CurrentRow.Cells[7].Value.ToString();
                        frm.TxtDireccion.Text = direccion;
                        Close();
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
