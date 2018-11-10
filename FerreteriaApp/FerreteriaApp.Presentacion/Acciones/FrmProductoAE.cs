using FerreteriaApp.Datos;
using FerreteriaApp.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Presentacion.Acciones
{
    public partial class FrmProductoAE : Form
    {
        public FrmProductoAE()
        {
            InitializeComponent();
        }
        public static int modificar = 0;
        public static bool BotonGuardar = false;
        private static string CarpetaImagen => "./ProductoImg";
        //combobox selected
        public static int cbxcategoriaselected = 0;
        public static int cbxsubcategoriaselected = 0;
        public static int cbxmarcaselected = 0;
        public static string cbxtipoexistenciaselected = "";
        public static string cbxunidadmedidaselected = "";
        private void FrmProductoAE_Load(object sender, EventArgs e)
        {
            CargarCategoria();
            CargarTipoExistencia();
            CargarUnidadMedida();
            CargarMarca();
            BtnGuardar.Enabled = BotonGuardar;
        }

        private void CargarCategoria()
        {
            DCategoria bo = new DCategoria();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxCategoria.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxCategoria.ValueMember = "Key";
                CbxCategoria.DisplayMember = "Value";
            }
            if(cbxcategoriaselected != 0)
            {
                CbxCategoria.SelectedValue = cbxcategoriaselected;
            }
        }

        private void CargarSubCategoria(int categoria)
        {
            DSubCategoria bo = new DSubCategoria();
            if (bo.CuadroCombinadoxCategoria(categoria).Count > 0)
            {
                CbxSubCategoria.DataSource = new BindingSource(bo.CuadroCombinadoxCategoria(categoria), null);
                CbxSubCategoria.ValueMember = "Key";
                CbxSubCategoria.DisplayMember = "Value";
            }
            if (cbxsubcategoriaselected != 0)
            {
                CbxSubCategoria.SelectedValue = cbxsubcategoriaselected;
            }
        }
        private void CargarTipoExistencia()
        {
            DTipoExistencia bo = new DTipoExistencia();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxTipoExistencia.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxTipoExistencia.ValueMember = "Key";
                CbxTipoExistencia.DisplayMember = "Value";
            }
            if (cbxtipoexistenciaselected != "")
            {
                CbxTipoExistencia.SelectedValue = cbxtipoexistenciaselected;
            }
        }
        private void CargarUnidadMedida()
        {
            DUnidadMedida bo = new DUnidadMedida();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxUnidadMedida.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxUnidadMedida.ValueMember = "Key";
                CbxUnidadMedida.DisplayMember = "Value";
            }
            CbxUnidadMedida.SelectedValue = "07";
            if (cbxunidadmedidaselected != "")
            {
                CbxUnidadMedida.SelectedValue = cbxunidadmedidaselected;
            }
        }

        private void CargarMarca()
        {
            DMarca bo = new DMarca();
            if (bo.CuadroCombinado().Count > 0)
            {
                CbxMarca.DataSource = new BindingSource(bo.CuadroCombinado(), null);
                CbxMarca.ValueMember = "Key";
                CbxMarca.DisplayMember = "Value";
            }
            if (cbxmarcaselected != 0)
            {
                CbxMarca.SelectedValue = cbxmarcaselected;
            }
        }
        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(CbxCategoria.SelectedValue != null)
                {
                    CbxSubCategoria.DataSource = null;
                    int categoria = Convert.ToInt32(CbxCategoria.SelectedValue);
                    CargarSubCategoria(categoria);
                }
            }
            catch
            {
                Console.WriteLine("Algo salio mal");
            }
        }
        
        private void Guardar()
        {
            string filename = PtbImagen.Image != null ? TxtCodigo.Text + ".jpg" : "default.jpg";
            Producto be = new Producto
            {
                Categoria = Convert.ToInt32(CbxCategoria.SelectedValue),
                SubCategoria = Convert.ToInt32(CbxSubCategoria.SelectedValue),
                Codigo = TxtCodigo.Text,
                Nombre = TxtNombre.Text,
                Imagen = filename,
                TipoExistencia = CbxTipoExistencia.SelectedValue.ToString(),
                UnidadMedida = CbxUnidadMedida.SelectedValue.ToString(),
                Marca = Convert.ToInt32(CbxMarca.SelectedValue),
                Estado = 1
            };
            DProducto bo = new DProducto();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    GuardarImagen(be.Codigo);
                    FrmProductos frm = Owner as FrmProductos;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Producto agregado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
            else if (modificar == 1)
            {
                if (bo.Modificar(be))
                {
                    GuardarImagen(be.Codigo);
                    FrmProductos frm = Owner as FrmProductos;
                    frm.Listar();
                    Close();
                    FrmPrincipal.Main.ChangeMessage("Producto modificado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }
        private void TxtCodigo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                BtnGuardar.Enabled = false;
                TxtCodigo.Focus();
            }
            else
            {
                DProducto bo = new DProducto();
                if (bo.VerificarCodigo(TxtCodigo.Text))
                {
                    BtnGuardar.Enabled = true;
                    TxtCodigo.BackColor = Color.FromArgb(126, 225, 154);
                }
                else
                {
                    BtnGuardar.Enabled = false;
                    TxtCodigo.BackColor = Color.FromArgb(241, 115, 117);
                    TxtCodigo.Focus();
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Ingrese Código del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodigo.Focus();
            }
            else if(string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingrese Nombre del Producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
            }
            else
            {
                Guardar();
            }
        }

        private void BtnUpImage_Click(object sender, EventArgs e)
        {       
            try
            {
                OpenFileDialog Abrir = new OpenFileDialog();
                Abrir.Filter = "jpg files (*.jpg)|*.jpg";
                Abrir.Title = "Upload an Image File";
                if (Abrir.ShowDialog() == DialogResult.OK)
                {
                    string imagen = Abrir.FileName;
                    PtbImagen.Image = Image.FromFile(imagen);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void BtnRemoverImagen_Click(object sender, EventArgs e)
        {
            try
            {
                PtbImagen.Image = null;
            }
            catch
            {
                Console.WriteLine("Algo salio mal");
            }
        }
        
        private void GuardarImagen(string filename)
        {
            try
            {
                if (!Directory.Exists(CarpetaImagen)) Directory.CreateDirectory(CarpetaImagen);
                string imgPath = CarpetaImagen + "/" + filename + ".jpg";
                if(PtbImagen.Image != null)
                {
                    if(modificar == 0)
                    {
                        PtbImagen.Image.Save(imgPath, ImageFormat.Jpeg);
                    }
                    else if(modificar == 1)
                    {
                        if (File.Exists(imgPath))
                        {
                            File.Delete(imgPath);
                        }
                        PtbImagen.Image.Save(imgPath, ImageFormat.Jpeg);
                    }  
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocurrio algun problema al guardar imagen");
                Console.WriteLine(e);
            }
        }
    }
}
