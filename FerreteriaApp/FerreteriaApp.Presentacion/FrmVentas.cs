using FerreteriaApp.Datos;
using FerreteriaApp.Presentacion.Acciones;
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
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            DVenta bo = new DVenta();
            DgvVenta.DataSource = bo.Listar();
        }

        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {
            FrmVenta frm = new FrmVenta();
            AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void BtnVerVenta_Click(object sender, EventArgs e)
        {
            if (DgvVenta.SelectedRows.Count > 0)
            {
                int rowindex = DgvVenta.CurrentRow.Index;
                if (rowindex != -1)
                {
                    try
                    {
                        string serie = DgvVenta.CurrentRow.Cells[4].Value.ToString();
                        string numero = DgvVenta.CurrentRow.Cells[5].Value.ToString();
                        FrmVistaVenta.Serie = serie;
                        FrmVistaVenta.Numero = numero;
                        FrmVistaVenta frm = new FrmVistaVenta();
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
            DVenta bo = new DVenta();
            DgvVenta.DataSource = bo.BuscarxFecha(FirstDate, LastDate);
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
