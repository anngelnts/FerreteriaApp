using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerreteriaApp.Presentacion.Reportes
{
    public partial class FrmVRProductosVendidos : Form
    {
        public FrmVRProductosVendidos()
        {
            InitializeComponent();
        }

        private void FrmVRProductosVendidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaAppDataSet.USP_R_ProductosVendidos' Puede moverla o quitarla según sea necesario.
            this.uSP_R_ProductosVendidosTableAdapter.Fill(this.ferreteriaAppDataSet.USP_R_ProductosVendidos);
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaAppDataSet.USP_R_ProductosVendidos' Puede moverla o quitarla según sea necesario.
            this.uSP_R_ProductosVendidosTableAdapter.Fill(this.ferreteriaAppDataSet.USP_R_ProductosVendidos);
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaAppDataSet.USP_R_ProductosVendidos' Puede moverla o quitarla según sea necesario.
            this.uSP_R_ProductosVendidosTableAdapter.Fill(this.ferreteriaAppDataSet.USP_R_ProductosVendidos);
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaAppDataSet.USP_R_ProductosVendidos' Puede moverla o quitarla según sea necesario.
            this.uSP_R_ProductosVendidosTableAdapter.Fill(this.ferreteriaAppDataSet.USP_R_ProductosVendidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
