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

namespace FerreteriaApp.Presentacion.Vistas
{
    public partial class FrmVistaCompra : Form
    {
        public FrmVistaCompra()
        {
            InitializeComponent();
        }

        public static string Serie;
        public static string Numero;

        private void FrmVistaCompra_Load(object sender, EventArgs e)
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
            DCompra venta = new DCompra();
            DataRow row = venta.SeleccionarCompra(Serie, Numero);
            if (row != null)
            {
                TxtTipoComprobante.Text = row["Tipo"].ToString();
                TxtSerie.Text = row["Serie"].ToString();
                TxtNumero.Text = row["Numero"].ToString();
                TxtFecha.Text = Convert.ToDateTime(row["Fecha"]).ToString("dd/MM/yyyy");
                TxtRucProveedor.Text = row["RUC"].ToString();
                TxtRazonSocial.Text = row["RazonSocial"].ToString();
                TxtPEmail.Text = row["Email"].ToString();
                TxtPTelefono.Text = row["Telefono"].ToString();
                TxtNDEmpleado.Text = row["NDE"].ToString();
                TxtNEmpleado.Text = row["ENombre"].ToString() + " " + row["EApellido"].ToString();
                RLblSubTotal.Text = "S/. " + row["SubTotal"].ToString();
                RLblIgv.Text = "S/. " + row["Igv"].ToString();
                RLblTotal.Text = "S/. " + row["Total"].ToString();
            }

        }

        private void CargarDetalle()
        {
            DDetalleCompra detalle = new DDetalleCompra();
            foreach (DataRow row in detalle.SeleccionarDetalle(Serie, Numero).Rows)
            {
                ListViewItem Items = new ListViewItem(row["Codigo"].ToString());
                Items.SubItems.Add(row["Nombre"].ToString());
                Items.SubItems.Add(row["Unidad"].ToString());
                Items.SubItems.Add(row["PrecioUnitario"].ToString());
                Items.SubItems.Add(row["Cantidad"].ToString());
                Items.SubItems.Add(row["PrecioTotal"].ToString());
                MLVDetalle.Items.Add(Items);
            }
        }
    }
}
