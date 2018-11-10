namespace FerreteriaApp.Entidades
{
    public class Inventario
    {
        public int ID { get; set; }
        public string Producto { get; set; }
        public double ValorUnitario { get; set; }
        public int Existencias { get; set; }
        public double ValorInventario { get; set; }
    }
}
