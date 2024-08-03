using System;

namespace ControlDelInventario.Infrastructure.Exceptions
{
    public class ProductoException : Exception
    {
        public ProductoException(string message) : base(message)
        {
        }
    }
}
