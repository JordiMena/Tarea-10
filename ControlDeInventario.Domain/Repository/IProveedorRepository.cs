using ControlDelInventario.Domain.Entities;
using System.Collections.Generic;

namespace ControlDelInventario.Domain.Repository
{
    public interface IProveedorRepository
    {
        Proveedor GetById(int id);
        IEnumerable<Proveedor> GetAll();
        void Add(Proveedor proveedor);
        void Update(Proveedor proveedor);
        void Delete(int id);
    }
}
