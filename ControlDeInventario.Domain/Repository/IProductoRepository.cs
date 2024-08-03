using System.Collections.Generic;
using ControlDeInventario.Domain.Entities;
using ControlDelInventario.Domain.Entities;

namespace ControlDeInventario.Domain.Interfaces
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetAll();
        Producto GetById(int id);
        void Add(Producto producto);
        void Update(Producto producto);
        void Delete(int id);
    }
}
