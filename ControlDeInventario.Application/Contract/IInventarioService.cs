using ControlDeInventario.Application.Dtos;
using ControlDelInventario.Application.Dtos;

namespace ControlDelInventario.Application.Contract
{
    public interface IInventarioService
    {
        IEnumerable<ProductoDto> ListarProductos();
        ProductoDto ObtenerProducto(int id);
        void AgregarProducto(ProductoDto productoDto);
        void ActualizarProducto(ProductoDto productoDto);
        void EliminarProducto(int id);
    }
}
