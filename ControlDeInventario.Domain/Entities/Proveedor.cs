using ControlDelInventario.Domain.Entities;

namespace ControlDelInventario.Domain.Entities
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        // Relación con Productos
        public ICollection<Producto> Productos { get; set; }
    }
}
