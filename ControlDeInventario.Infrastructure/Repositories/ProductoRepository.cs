using ControlDeInventario.Domain.Interfaces;
using ControlDelInventario.Domain.Entities;

namespace ControlDeInventario.Infrastructure.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Producto> GetAll()
        {
            return _context.Productos.ToList();
        }

        public Producto GetById(int id)
        {
            return _context.Productos.Find(id);
        }

        public void Add(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void Update(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
