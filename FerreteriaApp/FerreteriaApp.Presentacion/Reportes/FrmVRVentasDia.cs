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
    public partial class FrmVRVentasDia : Form
    {
        public FrmVRVentasDia()
        {
            InitializeComponent();
        }

        private void FrmVRVentasDia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaAppDataSet.USP_R_VentasdelDia' Puede moverla o quitarla según sea necesario.
            this.uSP_R_VentasdelDiaTableAdapter.Fill(this.ferreteriaAppDataSet.USP_R_VentasdelDia);

            this.reportViewer1.RefreshReport();
        }
    }
}
