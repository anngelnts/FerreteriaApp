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
    public partial class FrmBuscarProveedor : Form
    {
        public FrmBuscarProveedor()
        {
            InitializeComponent();
        }

        private void FrmBuscarProveedor_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            DProveedor bo = new DProveedor();
            DgvProveedor.DataSource = bo.Listar();
        }
        private void Buscar(string KeyWoard)
        {
            DProveedor bo = new DProveedor();
            DgvProveedor.DataSource = bo.Buscar(KeyWoard);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(TxtBusqueda.Text);
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvProveedor.SelectedRows.Count > 0)
            {
                int rowindex = DgvProveedor.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        FrmCompra frm = Owner as FrmCompra;
                        frm.LblIDProveedor.Text = DgvProveedor.CurrentRow.Cells[0].Value.ToString();
                        frm.TxtRucProveedor.Text = DgvProveedor.CurrentRow.Cells[1].Value.ToString();
                        frm.TxtRazonSocial.Text = DgvProveedor.CurrentRow.Cells[2].Value.ToString();
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
