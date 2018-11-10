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

namespace FerreteriaApp.Presentacion
{
    public partial class FrmMovimientos : Form
    {
        public FrmMovimientos()
        {
            InitializeComponent();
        }

        private void FrmMovimientos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        public void Listar()
        {
            DMovimiento bo = new DMovimiento();
            DgvMovimientos.DataSource = bo.Listar();
        }

        private void BtnMostrarMP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Ingrese Código del Producto");
            }
            else
            {
                DateTime desdemp = Convert.ToDateTime(DtpDesdeP.Text);
                DateTime hastamp = Convert.ToDateTime(DtpHastaP.Text);
                string codigo = TxtCodigo.Text;
                MostrarMovimientoProductoxFechas(desdemp, hastamp, codigo);
            }
        }
        private void MostrarMovimientoProductoxFechas(DateTime FirstDate, DateTime LastDate, string Producto)
        {
            DMovimiento bo = new DMovimiento();
            DgvMovProducto.DataSource = bo.ListarxFechasxProducto(FirstDate, LastDate, Producto);
        }

        private void BtnMTodosMP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Ingrese Código del Producto");
            }
            else
            {
                MostrarTodosMovimientoProducto();
            }  
        }

        private void MostrarTodosMovimientoProducto()
        {
            DMovimiento bo = new DMovimiento();
            DgvMovProducto.DataSource = bo.ListarxProducto(TxtCodigo.Text);
        }

        private void BtnMostrarPeriodoPM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigo.Text))
            {
                MessageBox.Show("Ingrese Código del Producto");
            }
            else if (string.IsNullOrEmpty(TxtPeriodo.Text))
            {
                MessageBox.Show("Ingrese Periodo");
            }
            else
            {
                MostrarxPerioddoMovimientoProducto();
            }
        }

        private void MostrarxPerioddoMovimientoProducto()
        {
            DMovimiento bo = new DMovimiento();
            DgvMovProducto.DataSource = bo.ListarxPeriodoxProducto(TxtPeriodo.Text, TxtCodigo.Text);
        }
    }
}
