namespace FerreteriaApp.Entidades
{
    public class DetalleVenta
    {
        public int ID { get; set; }
        public string Serie { get; set; }
        public string Numero { get; set; }
        public string Producto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double Importe { get; set; }
    }
}
