using ControlDeInventario.Domain.Interfaces;
using ControlDelInventario.Domain.Entities;
using ControlDelInventario.Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControlDelInventario.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Producto>> GetAll()
        {
            return Ok(_productoRepository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> GetById(int id)
        {
            var producto = _productoRepository.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }

        [HttpPost]
        public ActionResult<Producto> Create(Producto producto)
        {
            _productoRepository.Add(producto);
            return CreatedAtAction(nameof(GetById), new { id = producto.Id }, producto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            var existingProducto = _productoRepository.GetById(id);
            if (existingProducto == null)
            {
                return NotFound();
            }

            _productoRepository.Update(producto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var producto = _productoRepository.GetById(id);
            if (producto == null)
            {
                return NotFound();
            }

            _productoRepository.Delete(id);
            return NoContent();
        }
    }
}
