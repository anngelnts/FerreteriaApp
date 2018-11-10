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

namespace FerreteriaApp.Presentacion.Busqueda
{
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
        }

        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            DProducto bo = new DProducto();
            DgvProducto.DataSource = bo.Listar();
        }

        private void Buscar(string KeyWoard)
        {
            DProducto bo = new DProducto();
            DgvProducto.DataSource = bo.Buscar(KeyWoard);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                int rowindex = DgvProducto.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        FrmCompra frm = Owner as FrmCompra;
                        frm.TxtCodigo.Text = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtNombre.Text = DgvProducto.CurrentRow.Cells[4].Value.ToString();
                        frm.BtnAgregar.Enabled = true;
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
