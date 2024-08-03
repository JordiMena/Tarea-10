using ControlDeInventario.Domain.Entities;
using ControlDelInventario.Domain.Entities;
using System.Collections.Generic;

namespace ControlDelInventario.Domain.Repository
{
    public interface ICategoriaRepository
    {
        Categoria GetById(int id);
        IEnumerable<Categoria> GetAll();
        void Add(Categoria categoria);
        void Update(Categoria categoria);
        void Delete(int id);
    }
}
