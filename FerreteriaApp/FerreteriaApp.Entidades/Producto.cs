namespace FerreteriaApp.Entidades
{
    public class Producto
    {
        public int ID { get; set; }
        public int Categoria { get; set; }
        public int SubCategoria { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public string TipoExistencia { get; set; }
        public string UnidadMedida { get; set; }
        public int Marca { get; set; }
        public int Estado { get; set; }
    }
}
