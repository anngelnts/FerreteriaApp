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
    public partial class FrmCargoAE : Form
    {
        public FrmCargoAE()
        {
            InitializeComponent();
        }

        public static int modificar = 0;

        private void FrmCargoAE_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            DCargo bo = new DCargo();
            DgvCargo.DataSource = bo.Listar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDescripcion.Text))
            {
                MessageBox.Show("Ingre descripción del Cargo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescripcion.Focus();
            }
            else
            {
                Guardar();
            }
        }

        private void Guardar()
        {
            Cargo be = new Cargo
            {
                ID = Convert.ToInt32(lblIdentificador.Text),
                Descripcion = TxtDescripcion.Text
            };
            DCargo bo = new DCargo();
            if (modificar == 0)
            {
                if (bo.Agregar(be))
                {
                    TxtDescripcion.Text = "";
                    Listar();
                    FrmPrincipal.Main.ChangeMessage("Cargo agregado correctamente", "Success");
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
                    FrmPrincipal.Main.ChangeMessage("Cargo modificado correctamente", "Success");
                }
                else
                {
                    FrmPrincipal.Main.ChangeMessage("Algo salio mal, Intente de nuevo", "Failed");
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgvCargo.SelectedRows.Count > 0)
            {
                int rowindex = DgvCargo.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        modificar = 1;
                        BtnAgregar.Text = "Guardar";
                        BtnAgregar.BackColor = Color.FromArgb(0, 166, 81);
                        BtnCancelar.Visible = true;
                        BtnEditar.Enabled = false;
                        lblIdentificador.Text = DgvCargo.CurrentRow.Cells[0].Value.ToString();
                        TxtDescripcion.Text = DgvCargo.CurrentRow.Cells[1].Value.ToString();
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
            TxtDescripcion.Text = "";
            BtnCancelar.Visible = false;
            BtnEditar.Enabled = true;
        }

        private void DgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modificar == 1)
            {
                try
                {
                    lblIdentificador.Text = DgvCargo.CurrentRow.Cells[0].Value.ToString();
                    TxtDescripcion.Text = DgvCargo.CurrentRow.Cells[1].Value.ToString();
                }
                catch
                {
                    //
                }
            }
        }
    }
}
