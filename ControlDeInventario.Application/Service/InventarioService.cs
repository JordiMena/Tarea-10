using ControlDeInventario.Application.Dtos;
using ControlDeInventario.Domain.Interfaces;
using ControlDelInventario.Application.Contract;
using ControlDelInventario.Application.Dtos;
using ControlDelInventario.Domain.Entities;
using ControlDelInventario.Domain.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ControlDelInventario.Application.Services
{
    public class InventarioService : IInventarioService
    {
        private readonly IProductoRepository _productoRepository;

        public InventarioService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public IEnumerable<ProductoDto> ListarProductos()
        {
            return _productoRepository.GetAll().Select(p => new ProductoDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Precio = p.Precio,
                // Mapear otras propiedades según sea necesario
            });
        }

        public ProductoDto ObtenerProducto(int id)
        {
            var producto = _productoRepository.GetById(id);
            return new ProductoDto
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Precio = producto.Precio,
                // Mapear otras propiedades según sea necesario
            };
        }

        public void AgregarProducto(ProductoDto productoDto)
        {
            var producto = new Producto
            {
                Nombre = productoDto.Nombre,
                Precio = productoDto.Precio,
                // Mapear otras propiedades según sea necesario
            };
            _productoRepository.Add(producto);
        }

        public void ActualizarProducto(ProductoDto productoDto)
        {
            var producto = _productoRepository.GetById(productoDto.Id);
            if (producto != null)
            {
                producto.Nombre = productoDto.Nombre;
                producto.Precio = productoDto.Precio;
                // Mapear otras propiedades según sea necesario
                _productoRepository.Update(producto);
            }
        }

        public void EliminarProducto(int id)
        {
            _productoRepository.Delete(id);
        }
    }
}
