using ControlDelInventario.Domain.Repository;
using System;
using System.Collections.Generic;

namespace ControlDelInventario.Application.Core
{
    public abstract class BaseService<T> : IBaseService<T>
    {
        protected readonly IRepository<T> _repository;

        protected BaseService(IRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual IEnumerable<T> ListarTodos()
        {
            return _repository.GetAll();
        }

        public virtual T ObtenerPorId(int id)
        {
            return _repository.GetById(id);
        }

        public virtual void Agregar(T entidad)
        {
            _repository.Add(entidad);
        }

        public virtual void Actualizar(T entidad)
        {
            _repository.Update(entidad);
        }

        public virtual void Eliminar(int id)
        {
            _repository.Delete(id);
        }

        protected void Log(string message)
        {
            // Implementación del método de registro
            Console.WriteLine(message);
        }

        protected void HandleException(Exception ex)
        {
            // Implementación del manejo de excepciones
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
