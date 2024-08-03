using ControlDeInventario.Infrastructure;
using ControlDelInventario.Domain.Entities;
using ControlDelInventario.Domain.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ControlDelInventario.Infrastructure.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly ApplicationDbContext _context;

        public ProveedorRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Proveedor GetById(int id)
        {
            return _context.Proveedores.Find(id);
        }

        public IEnumerable<Proveedor> GetAll()
        {
            return _context.Proveedores.ToList();
        }

        public void Add(Proveedor proveedor)
        {
            _context.Proveedores.Add(proveedor);
            _context.SaveChanges();
        }

        public void Update(Proveedor proveedor)
        {
            _context.Proveedores.Update(proveedor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var proveedor = _context.Proveedores.FirstOrDefault(p => p.Id == id);
            if (proveedor != null)
            {
                _context.Proveedores.Remove(proveedor);
                _context.SaveChanges();
            }
        }
    }
}
