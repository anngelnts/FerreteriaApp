using System;

namespace FerreteriaApp.Entidades
{
    public class Compra
    {
        public int ID { get; set; }
        public int Proveedor { get; set; }
        public int Empleado { get; set; }
        public string TipoComprobante { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
        public double Igv { get; set; }
        public double Total { get; set; }
        public int Estado { get; set; }
    }
}
