namespace ControlDeInventario.Application.Dtos
{
    public class OtraEntidadDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
        
        // Agrega más propiedades aquí si tu entidad OtraEntidad tiene más atributos que necesitas transferir.
    }
}
