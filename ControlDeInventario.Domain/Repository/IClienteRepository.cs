using ControlDeInventario.Domain.Entities;
using ControlDelInventario.Domain.Entities;
using System.Collections.Generic;

namespace ControlDelInventario.Domain.Repository
{
    public interface IClienteRepository
    {
        Cliente GetById(int id);
        IEnumerable<Cliente> GetAll();
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
    }
}
