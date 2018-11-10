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

namespace FerreteriaApp.Presentacion.Vistas
{
    public partial class FrmVistaVenta : Form
    {
        public FrmVistaVenta()
        {
            InitializeComponent();
        }

        public static string Serie;
        public static string Numero;

        private void FrmVistaVenta_Load(object sender, EventArgs e)
        {
            CargarDatos();
            InitListaDetalle();
            CargarDetalle();
        }

        private void InitListaDetalle()
        {
            MLVDetalle.BackColor = Color.White;
            MLVDetalle.ForeColor = Color.Black;
            MLVDetalle.Dock = DockStyle.Fill;
            MLVDetalle.View = View.Details;
            MLVDetalle.FullRowSelect = true;
            MLVDetalle.Columns.Add("Código", 100, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("Descripción", 250, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("UM", 100, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("Precio", 100, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("Cantidad", 100, HorizontalAlignment.Left);
            MLVDetalle.Columns.Add("Importe", 100, HorizontalAlignment.Left);
        }

        private void CargarDatos()
        {
            DVenta venta = new DVenta();
            DataRow row = venta.SeleccionarVenta(Serie, Numero);
            if (row != null)
            {
                TxtTipoComprobante.Text = row["Tipo"].ToString();
                TxtSerie.Text = row["Serie"].ToString();
                TxtNumero.Text = row["Numero"].ToString();
                TxtFechaEmision.Text = Convert.ToDateTime(row["Fecha"]).ToString("dd/MM/yyyy");
                TxtNumeroDocumento.Text = row["NDC"].ToString();
                TxtNombres.Text = row["CNombre"].ToString() + " " + row["CApellido"].ToString();
                TxtDireccion.Text = row["CDireccion"].ToString() + ", " + row["CCiudad"].ToString();
                TxtNDEmpleado.Text = row["NDE"].ToString();
                TxtNEmpleado.Text = row["ENombre"].ToString() + " " + row["EApellido"].ToString();
                RLblSubTotal.Text = "S/. " + row["SubTotal"].ToString();
                RLblIgv.Text = "S/. " + row["Igv"].ToString();
                RLblTotal.Text = "S/. " + row["Total"].ToString();
            }

        }

        private void CargarDetalle()
        {
            DDetalleVenta detalle = new DDetalleVenta();
            foreach (DataRow row in detalle.SeleccionarDetalle(Serie, Numero).Rows)
            {
                ListViewItem Items = new ListViewItem(row["Codigo"].ToString());
                Items.SubItems.Add(row["Nombre"].ToString());
                Items.SubItems.Add(row["Unidad"].ToString());
                Items.SubItems.Add(row["Precio"].ToString());
                Items.SubItems.Add(row["Cantidad"].ToString());
                Items.SubItems.Add(row["Importe"].ToString());
                MLVDetalle.Items.Add(Items);
            }
        }

    }
}
