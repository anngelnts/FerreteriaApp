using FerreteriaApp.Datos;
using FerreteriaApp.Entidades;
using FerreteriaApp.Presentacion.Acciones;
using FerreteriaApp.Presentacion.Otros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Presentacion
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        private static string CarpetaImagen => "./ProductoImg";
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductoAE.modificar = 0;
            FrmProductoAE frm = new FrmProductoAE();
            AddOwnedForm(frm);
            frm.Text = "Nuevo Producto";
            frm.ShowDialog();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Listar();
            CargarImagenSeleccionado();
        }
        public void Listar()
        {
            DProducto bo = new DProducto();
            DgvProducto.DataSource = bo.Listar();
        }
        private void Buscar(string KeyWoards)
        {
            DProducto bo = new DProducto();
            DgvProducto.DataSource = bo.Buscar(KeyWoards);
        }

        private void BtnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frm = new FrmCategorias();
            frm.ShowDialog();
        }

        private void BtnSubCategorias_Click(object sender, EventArgs e)
        {
            FrmSubCategorias frm = new FrmSubCategorias();
            frm.ShowDialog();
        }

        private void BtnMarcas_Click(object sender, EventArgs e)
        {
            FrmMarcas frm = new FrmMarcas();
            frm.ShowDialog();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            FrmInventarioSingle frm = new FrmInventarioSingle();
            frm.ShowDialog();
        }

        private void DgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarImagenSeleccionado();
        }
        private void CargarImagenSeleccionado()
        {
            try
            {
                TxtCodigoImagen.Text = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                string image = DgvProducto.CurrentRow.Cells[5].Value.ToString();
                if (image != null)
                {
                    SeleccionarImagen(image);
                }
                else
                {
                    SeleccionarImagen("default.jpg");
                }
            }
            catch
            {
                //
            }
        }
        private void SeleccionarImagen(string image)
        {
            string imagen = CarpetaImagen + "/" + image;
            if (File.Exists(imagen))
            {
                PtbImageProdcucto.Image = Image.FromFile(imagen);
            }
            else
            {
                PtbImageProdcucto.Image = Image.FromFile(CarpetaImagen+"/default.jpg");
            }
            
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (DgvProducto.SelectedRows.Count > 0)
            {
                int rowindex = DgvProducto.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        string nameimage = DgvProducto.CurrentRow.Cells[5].Value.ToString() == null ? "default.jpg" : DgvProducto.CurrentRow.Cells[5].Value.ToString();
                        string imagen = CarpetaImagen + "/" + nameimage;
                        FrmProductoAE.modificar = 1;
                        FrmProductoAE frm = new FrmProductoAE();
                        AddOwnedForm(frm);
                        frm.Text = "Modificar Producto";
                        FrmProductoAE.BotonGuardar = true;
                        frm.TxtCodigo.Enabled = false;
                        frm.TxtNombre.Enabled = false;
                        FrmProductoAE.cbxcategoriaselected = Convert.ToInt32(DgvProducto.CurrentRow.Cells[1].Value);
                        FrmProductoAE.cbxsubcategoriaselected = Convert.ToInt32(DgvProducto.CurrentRow.Cells[2].Value);
                        frm.TxtCodigo.Text = DgvProducto.CurrentRow.Cells[3].Value.ToString();
                        frm.TxtNombre.Text = DgvProducto.CurrentRow.Cells[4].Value.ToString();
                        if (File.Exists(imagen))
                        {
                            frm.PtbImagen.Image = Image.FromFile(imagen);
                        }
                        else
                        {
                            frm.PtbImagen.Image = Image.FromFile(CarpetaImagen + "/default.jpg");
                        }
                        FrmProductoAE.cbxtipoexistenciaselected = DgvProducto.CurrentRow.Cells[6].Value.ToString();
                        FrmProductoAE.cbxunidadmedidaselected = DgvProducto.CurrentRow.Cells[7].Value.ToString();
                        FrmProductoAE.cbxmarcaselected = Convert.ToInt32(DgvProducto.CurrentRow.Cells[8].Value);
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
            Buscar(TxtBusqueda.Text);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
