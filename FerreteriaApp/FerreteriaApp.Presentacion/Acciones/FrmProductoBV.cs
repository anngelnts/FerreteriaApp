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
    public partial class FrmProductoBV : Form
    {
        public FrmProductoBV()
        {
            InitializeComponent();
        }
        private static string CarpetaImagen => "./ProductoImg";

        private void FrmProductoBV_Load(object sender, EventArgs e)
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
                        FrmVenta frm = Owner as FrmVenta;
                        string codigoproducto = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtProducto.Text = codigoproducto;
                        DProducto boProducto = new DProducto();
                        Producto producto = boProducto.Seleccionar(codigoproducto);
                        if (string.IsNullOrEmpty(producto.Codigo))
                        {
                            MessageBox.Show("No Existe Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            DInventario boInventario = new DInventario();
                            Inventario inventario = boInventario.Seleccionar(producto.Codigo);
                            if (!string.IsNullOrEmpty(inventario.Producto))
                            {
                                if (inventario.Existencias > 0)
                                {
                                    double utilidad = FrmPrincipal.ValorUtilidad;
                                    double precioventa = Math.Round((inventario.ValorUnitario * utilidad), 2);
                                    frm.AddItems(producto, 1, precioventa);
                                    //Mostrar imagen
                                    if (!string.IsNullOrEmpty(producto.Imagen))
                                    {
                                        frm.PbxImgProducto.Image = Image.FromFile(CarpetaImagen + "/" + producto.Imagen);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No hay Cantidad Suficiente");
                                }
                            }
                        }
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

        private void DgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosProducto();
        }

        private void CargarDatosProducto()
        {
            try
            {
                string codigoproducto = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                DInventario boInventario = new DInventario();
                Inventario inventario = boInventario.Seleccionar(codigoproducto);
                TxtProducto.Text = DgvProducto.CurrentRow.Cells[4].Value.ToString();
                TxtExistencias.Text = inventario.Existencias.ToString();
                txtPrecioCompra.Text = inventario.ValorUnitario.ToString("N2");
                double precioventa = Math.Round((inventario.ValorUnitario * FrmPrincipal.ValorUtilidad), 2);
                TxtPrecioVenta.Text = precioventa.ToString("N2");
            }
            catch
            {
                //
            }
        }
    }
}
