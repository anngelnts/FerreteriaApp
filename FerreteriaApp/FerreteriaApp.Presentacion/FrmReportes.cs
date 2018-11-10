using FerreteriaApp.Presentacion.Reportes;
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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

            //
        }

        private void BtnExistenciaProductos_Click(object sender, EventArgs e)
        {
            FrmVRExistenciaProductos frm = new FrmVRExistenciaProductos();
            frm.Show();
        }

        private void BtnProductosVendidos_Click(object sender, EventArgs e)
        {
            FrmVRProductosVendidos frm = new FrmVRProductosVendidos();
            frm.Show();
        }

        private void BtnVentasDia_Click(object sender, EventArgs e)
        {
            FrmVRVentasDia frm = new FrmVRVentasDia();
            frm.Show();
        }
    }
}
