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
    public partial class FrmVRExistenciaProductos : Form
    {
        public FrmVRExistenciaProductos()
        {
            InitializeComponent();
        }

        private void FrmVRExistenciaProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaAppDataSet.USP_R_ExistenciaProductosOrderExistencia' Puede moverla o quitarla según sea necesario.
            this.uSP_R_ExistenciaProductosOrderExistenciaTableAdapter.Fill(this.ferreteriaAppDataSet.USP_R_ExistenciaProductosOrderExistencia);

            this.reportViewer1.RefreshReport();
        }
    }
}
