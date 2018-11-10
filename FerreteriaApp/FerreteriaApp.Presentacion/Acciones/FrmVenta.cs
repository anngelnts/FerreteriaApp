using FerreteriaApp.Datos;
using FerreteriaApp.Entidades;
using MaterialSkin;
using System;
using System.Collections;
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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
            //Iniciar Componentes de MaterialSkin
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green500, Primary.Blue400, Accent.Blue700, TextShade.WHITE);
        }

        private static string CarpetaImagen => "./ProductoImg";

        public static double Venta_SubTotal = 0;
        public static double Venta_Igv = 0;
        public static double Venta_Total = 0;

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            InitListaDetalle();
            GbxComprobante.ForeColor = Color.White;
            GbxCliente.ForeColor = Color.White;
            GbxDetalle.ForeColor = Color.White;
            GbxResumen.ForeColor = Color.White;
            //CargarDatos
            CargarTipoComprobanteFB();
            FechaActual();
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

        private void CargarTipoComprobanteFB()
        {
            DTipoComprobante bo = new DTipoComprobante();
            if (bo.CuadroCombinadoFB().Count > 0)
            {
                CbxTipoComprobante.DataSource = new BindingSource(bo.CuadroCombinadoFB(), null);
                CbxTipoComprobante.ValueMember = "Key";
                CbxTipoComprobante.DisplayMember = "Value";
            }
            CbxTipoComprobante.SelectedValue = "01";
        }
        private void FechaActual()
        {
            DateTime dt = DateTime.Now;
            TxtFechaEmision.Text = dt.ToShortDateString();
        }

        public void AddItems(Producto producto, int Existencia, double ValorUnitario)
        {
            bool nuevo = true;
            if(MLVDetalle.Items.Count > 0)
            {
                foreach (ListViewItem items in MLVDetalle.Items)
                {
                    if(items.SubItems[0].Text.Equals(producto.Codigo))
                    {
                        int cantidad = Convert.ToInt32(items.SubItems[4].Text) + Existencia;
                        items.SubItems[3].Text = ValorUnitario.ToString();
                        items.SubItems[4].Text = cantidad.ToString();
                        items.SubItems[5].Text = (ValorUnitario * cantidad).ToString();
                        nuevo = false;
                    }
                }
            }
            if(nuevo == true)
            {
                ListViewItem Items = new ListViewItem(producto.Codigo);
                Items.SubItems.Add(producto.Nombre);
                Items.SubItems.Add(producto.UnidadMedida);
                Items.SubItems.Add(ValorUnitario.ToString());
                Items.SubItems.Add(Existencia.ToString());
                Items.SubItems.Add((ValorUnitario * Existencia).ToString());
                MLVDetalle.Items.Add(Items);
            }
            ActualizarResumen();
        }
        private void ActualizarCantidad(string operation, int quantity = 1)
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                string codigoproducto = MLVDetalle.SelectedItems[0].SubItems[0].Text;
                DInventario boInventario = new DInventario();
                Inventario inventario = boInventario.Seleccionar(codigoproducto);
                //Datos
                double precio = Convert.ToDouble(MLVDetalle.SelectedItems[0].SubItems[3].Text);
                int cantidad = Convert.ToInt32(MLVDetalle.SelectedItems[0].SubItems[4].Text);
                if (operation.Equals("Aumentar"))
                {
                    if (cantidad < inventario.Existencias)
                        cantidad += quantity;
                    else
                        MessageBox.Show("No hay mas productos");
                }
                else if (operation.Equals("Disminuir"))
                {
                    cantidad -= quantity;
                }
                else if (operation.Equals("Nueva"))
                {
                    if (quantity <= inventario.Existencias)
                        cantidad = quantity;
                    else
                        MessageBox.Show("No hay mas productos");
                }
                double importe = precio * cantidad;
                MLVDetalle.SelectedItems[0].SubItems[4].Text = cantidad.ToString();
                MLVDetalle.SelectedItems[0].SubItems[5].Text = importe.ToString();
                TxtCantidadItem.Text = cantidad.ToString();
                ActualizarResumen();
            }
            else
            {
                MessageBox.Show("Seleccione Item");
            }
        }
        private void ActualizarResumen()
        {
            double SubTotal = 0;
            double Igv = 0;
            double Total = 0;
            if (MLVDetalle.Items.Count > 0)
            {
                foreach(ListViewItem items in MLVDetalle.Items)
                {
                    Total += Convert.ToDouble(items.SubItems[5].Text);
                }
                SubTotal = Total / 1.18;
                Igv = Total - (Total / 1.18);
                RLblSubTotal.Text = "S/. " + SubTotal.ToString("N2");
                RLblIgv.Text = "S/. " + Igv.ToString("N2");
                RLblTotal.Text = "S/. " + Total.ToString("N2");
            }
            else
            {
                RLblSubTotal.Text = "S/. " + SubTotal.ToString("N2");
                RLblIgv.Text = "S/. " + Igv.ToString("N2");
                RLblTotal.Text = "S/. " + Total.ToString("N2");
            }
            //Asignando variables
            Venta_SubTotal = Math.Round(SubTotal, 2);
            Venta_Igv = Math.Round(Igv, 2);
            Venta_Total = Math.Round(Total, 2);
        }
        private void BtnSearchCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void MLVDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                TxtCantidadItem.Text = MLVDetalle.SelectedItems[0].SubItems[4].Text;
                BtnDisminuirItem.Enabled = true;
            }
        }

        private void BtnAumentarItem_Click(object sender, EventArgs e)
        {
            ActualizarCantidad("Aumentar");
        }

        private void BtnDisminuirItem_Click(object sender, EventArgs e)
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                if (Convert.ToInt32(MLVDetalle.SelectedItems[0].SubItems[4].Text) <= 1)
                {
                    RemoverItem();
                    BtnDisminuirItem.Enabled = false;
                }
                else
                {
                    ActualizarCantidad("Disminuir");
                }
            }
        }
        private void RemoverItem()
        {
            if (MLVDetalle.SelectedItems.Count > 0)
            {
                MLVDetalle.Items.Remove(MLVDetalle.SelectedItems[0]);
                ActualizarResumen();
            }
            else
            {
                MessageBox.Show("Seleccione Item");
            }
        }

        private void TxtCantidadItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != Convert.ToChar(Keys.Enter)))
            {
                //Solo se permiten numeros
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if(string.IsNullOrEmpty(TxtCantidadItem.Text))
                {
                    MessageBox.Show("Ingrese valor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if(Convert.ToInt32(TxtCantidadItem.Text) == 0)
                    {
                        MessageBox.Show("El valor no puede ser 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                    }
                    else
                    {
                        ActualizarCantidad("Nueva", Convert.ToInt32(TxtCantidadItem.Text));
                    }
                }
            }
        }

        private void TxtNumeroDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
                {
                    MessageBox.Show("Ingrese Número de Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DCliente boCliente = new DCliente();
                    Cliente cliente = boCliente.Seleccionar(TxtNumeroDocumento.Text);
                    if (string.IsNullOrEmpty(cliente.NumeroDocumento))
                    {
                        MessageBox.Show("No Existe Cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        LblIDCliente.Text = cliente.ID.ToString();
                        TxtNombres.Text = cliente.Nombre + " " + cliente.Apellido;
                        TxtDireccion.Text = cliente.Direccion + ", " + cliente.Ciudad;
                    }
                }
            }
        }

        private void TxtNumeroDocumento_TextChanged(object sender, EventArgs e)
        {
            TxtNombres.Text = "";
            TxtDireccion.Text = "";
        }

        private void TxtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (string.IsNullOrEmpty(TxtProducto.Text))
                {
                    MessageBox.Show("Ingrese Código del Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DProducto boProducto = new DProducto();
                    Producto producto = boProducto.Seleccionar(TxtProducto.Text);
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
                                AddItems(producto, 1, precioventa);
                                //Mostrar imagen
                                if (!string.IsNullOrEmpty(producto.Imagen))
                                {
                                    PbxImgProducto.Image = Image.FromFile(CarpetaImagen + "/" + producto.Imagen);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No hay Cantidad Suficiente");
                            }
                        } 
                    }
                }
            }
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            RemoverItem();
        }

        private void BtnSearchProducto_Click(object sender, EventArgs e)
        {
            FrmProductoBV frm = new FrmProductoBV();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void BtnGuardarVenta_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CbxTipoComprobante.Text))
            {
                MessageBox.Show("Seleccione Tipo de Comprobante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CbxTipoComprobante.Focus();
            }
            else if (string.IsNullOrEmpty(TxtSerie.Text))
            {
                MessageBox.Show("Digite Serie del Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtSerie.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNumero.Text))
            {
                MessageBox.Show("Digite Número del Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumero.Focus();
            }
            else if (string.IsNullOrEmpty(TxtFechaEmision.Text))
            {
                MessageBox.Show("Ingrese Fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtFechaEmision.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNumeroDocumento.Text))
            {
                MessageBox.Show("Ingrese un Cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNumeroDocumento.Focus();
            }
            else if (string.IsNullOrEmpty(TxtNombres.Text))
            {
                MessageBox.Show("Cliente Incorrecto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombres.Focus();
            }
            else if (MLVDetalle.Items.Count == 0)
            {
                MessageBox.Show("El detalle no puede estar vacío, agrege items", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtProducto.Focus();
            }
            else
            {
                GuardarVenta();
            }
        }

        private void GuardarVenta()
        {
            string tipocomprobante = CbxTipoComprobante.SelectedValue.ToString();
            string ventaserie = "####";
            string ventacorrelativo = "########";
            DVenta venta = new DVenta();
            if (venta.ObtenerSerieCorrelativo(tipocomprobante) != null)
            {
                DataRow row = venta.ObtenerSerieCorrelativo(tipocomprobante);
                ventaserie = row["Serie"].ToString();
                ventacorrelativo = row["Correlativo"].ToString();
            }
            Venta beVenta = new Venta
            {
                Cliente = Convert.ToInt32(LblIDCliente.Text),
                Empleado = FrmPrincipal.AccesoUsernameID,
                TipoComprobante = tipocomprobante,
                Serie = ventaserie,
                Numero = ventacorrelativo,
                Fecha = Convert.ToDateTime(DateTime.Now),
                Hora = Convert.ToDateTime(DateTime.Now),
                SubTotal = Venta_SubTotal,
                Igv = Venta_Igv,
                Total = Venta_Total,
                Estado = 1
            };
            DVenta boVenta = new DVenta();
            if (boVenta.Agregar(beVenta) == true)
            {
                if (MLVDetalle.Items.Count > 0)
                {
                    DDetalleVenta boDetalleVenta = new DDetalleVenta();
                    foreach (ListViewItem items in MLVDetalle.Items)
                    {
                        DetalleVenta beDetalleVenta = new DetalleVenta
                        {
                            Serie = beVenta.Serie,
                            Numero = beVenta.Numero,
                            Producto = items.SubItems[0].Text,
                            Precio = Convert.ToDouble(items.SubItems[3].Text),
                            Cantidad = Convert.ToInt32(items.SubItems[4].Text),
                            Importe = Convert.ToDouble(items.SubItems[5].Text)
                        };
                        //Agregar dettalle compra
                        if (boDetalleVenta.Agregar(beDetalleVenta) == true)
                        {
                            int cantidadfinal = 0;
                            double costounitariofinal = 0;
                            double costototalfinal = 0;
                            //Obteniendo Ultimo Movimiento
                            DMovimiento boM = new DMovimiento();
                            Movimiento datos = boM.SeleccionarUltimoMovimientoProducto(beDetalleVenta.Producto);
                            if (!string.IsNullOrEmpty(datos.Producto))
                            {
                                //Si hay datos
                                cantidadfinal = datos.CantidadFinal - beDetalleVenta.Cantidad;
                                costounitariofinal = datos.CostoUnitarioFinal;
                                double costofinaly = Math.Round((costounitariofinal * beDetalleVenta.Cantidad),2);
                                costototalfinal = datos.CostoTotalFinal - costofinaly;
                                //Movimiento
                                Movimiento beMovimiento = new Movimiento
                                {
                                    Fecha = DateTime.Now,
                                    TipoComprobante = beVenta.TipoComprobante,
                                    Serie = beVenta.Serie,
                                    Numero = beVenta.Numero,
                                    TipoOperacion = "01",
                                    Producto = beDetalleVenta.Producto,
                                    CantidadEntrada = 0,
                                    CostoUnitarioEntrada = 0,
                                    CostoTotalEntrada = 0,

                                    CantidadSalida = beDetalleVenta.Cantidad,
                                    CostoUnitarioSalida = costounitariofinal,
                                    CostoTotalSalida = costofinaly,

                                    CantidadFinal = cantidadfinal,
                                    CostoUnitarioFinal = costounitariofinal,
                                    CostoTotalFinal = costototalfinal
                                };
                                DMovimiento boMovimiento = new DMovimiento();
                                if (boMovimiento.Agregar(beMovimiento) == true)
                                {
                                    Inventario beInventario = new Inventario
                                    {
                                        Producto = beMovimiento.Producto,
                                        ValorUnitario = beMovimiento.CostoUnitarioFinal,
                                        Existencias = beMovimiento.CantidadFinal,
                                        ValorInventario = beMovimiento.CostoTotalFinal
                                    };
                                    DInventario boInventario = new DInventario();
                                    boInventario.Modificar(beInventario);
                                }
                            }
                        }
                    }
                }
                //message
                FrmVentas frm = Owner as FrmVentas;
                frm.Listar();
                Close();
                FrmPrincipal.Main.ChangeMessage("La Venta se ingreso correctamente", "Success");
            }
            else
            {
                FrmPrincipal.Main.ChangeMessage("Algo salio mal", "Failed");
            }
        }
    }
}
