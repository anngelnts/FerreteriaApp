using FerreteriaApp.Datos;
using FerreteriaApp.Presentacion.Acciones;
using FerreteriaApp.Presentacion.Otros;
using FerreteriaApp.Presentacion.Vistas;
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
    public partial class FrmCompras : Form
    {
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void BtnNuevaCompra_Click(object sender, EventArgs e)
        {
            FrmCompra frm = new FrmCompra();
            AddOwnedForm(frm);
            frm.Text = "Nueva Compra";
            frm.ShowDialog();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.ShowDialog();
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            Listar();
        }
        
        public void Listar()
        {
            DCompra bo = new DCompra();
            DgvCompra.DataSource = bo.Listar();
        }

        private void BtnVerCompra_Click(object sender, EventArgs e)
        {
            if (DgvCompra.SelectedRows.Count > 0)
            {
                int rowindex = DgvCompra.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        string serie = DgvCompra.CurrentRow.Cells[4].Value.ToString();
                        string numero = DgvCompra.CurrentRow.Cells[5].Value.ToString();
                        FrmVistaCompra.Serie = serie;
                        FrmVistaCompra.Numero = numero;
                        FrmVistaCompra frm = new FrmVistaCompra();
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

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime desde = Convert.ToDateTime(DtpFirstDate.Text);
            DateTime hasta = Convert.ToDateTime(DtpLastDate.Text);
            BuscarxFecha(desde, hasta);
        }
        private void BuscarxFecha(DateTime FirstDate, DateTime LastDate)
        {
            DCompra bo = new DCompra();
            DgvCompra.DataSource = bo.BuscarxFecha(FirstDate, LastDate);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
