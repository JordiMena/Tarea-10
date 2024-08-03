namespace ControlDelInventario.Application.Dtos
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Inicializado con valor predeterminado
        public decimal Precio { get; set; }
        // Otras propiedades según sea necesario
    }
}
