namespace ControlDelInventario.Application.Core
{
    public interface IBaseService<T>
    {
        IEnumerable<T> ListarTodos();
        T ObtenerPorId(int id);
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(int id);
    }
}
