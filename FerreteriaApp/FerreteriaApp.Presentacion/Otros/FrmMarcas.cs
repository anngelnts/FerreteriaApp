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

namespace FerreteriaApp.Presentacion.Otros
{
    public partial class FrmMarcas : Form
    {
        public FrmMarcas()
        {
            InitializeComponent();
        }
        public static int modificar = 0;

        private void FrmMarcas_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void Listar()
        {
            DMarca bo = new DMarca();
            DgvMarca.DataSource = bo.Listar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingre nombre de la Marca", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtNombre.Focus();
            }
            else
            {
                Guardar();
            }
        }
        private void Guardar()
        {
            Marca be = new Marca
            {
                ID = Convert.ToInt32(lblIdentificador.Text),
                Nombre = TxtNombre.Text
            };
            DMarca bo = new DMarca();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    TxtNombre.Text = "";
                    Listar();
                    FrmPrincipal.Main.ChangeMessage("Marca agregado correctamente", "Success");
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
                    Listar();
                    FrmPrincipal.Main.ChangeMessage("Marca modificado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvMarca.SelectedRows.Count > 0)
            {
                int rowindex = DgvMarca.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        modificar = 1;
                        BtnAgregar.Text = "Guardar";
                        BtnAgregar.BackColor = Color.FromArgb(0, 166, 81);
                        BtnCancelar.Visible = true;
                        BtnEditar.Enabled = false;
                        lblIdentificador.Text = DgvMarca.CurrentRow.Cells[0].Value.ToString();
                        TxtNombre.Text = DgvMarca.CurrentRow.Cells[1].Value.ToString();
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            modificar = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.BackColor = Color.FromArgb(66, 139, 202);
            TxtNombre.Text = "";
            BtnCancelar.Visible = false;
            BtnEditar.Enabled = true;
        }

        private void DgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == 1)
            {
                try
                {
                    lblIdentificador.Text = DgvMarca.CurrentRow.Cells[0].Value.ToString();
                    TxtNombre.Text = DgvMarca.CurrentRow.Cells[1].Value.ToString();
                }
                catch
                {
                    //
                }
            }
        }
    }
}
