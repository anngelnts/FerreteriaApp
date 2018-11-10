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

namespace FerreteriaApp.Presentacion.Otros
{
    public partial class FrmInventarioSingle : Form
    {
        public FrmInventarioSingle()
        {
            InitializeComponent();
        }

        private void FrmInventarioSingle_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            DInventario bo = new DInventario();
            DgvInventarioSingle.DataSource = bo.Listar();
        }
        private void Buscar(string KeyWords)
        {
            DInventario bo = new DInventario();
            DgvInventarioSingle.DataSource = bo.Buscar(KeyWords);
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
