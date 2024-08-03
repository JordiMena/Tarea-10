using ControlDeInventario.Domain.Entities;
using ControlDeInventario.Infrastructure;
using ControlDelInventario.Domain.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ControlDelInventario.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Cliente GetById(int id)
        {
            return _context.Clientes.Find(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Clientes.ToList();
        }

        public void Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void Update(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}
