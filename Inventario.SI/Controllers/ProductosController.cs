using Inventario.BL;
using Inventario.MODEL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventario.SI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly GestorInventario _gestor;

        public ProductosController(GestorInventario gestor)
        {
            _gestor = gestor;
        }

        // GET: api/productos
        [HttpGet]
        public IActionResult ObtenerProductos()
        {
            var productos = _gestor.ObtenerProductos();
            return Ok(productos);
        }

        // GET: api/productos/5
        [HttpGet("{id}")]
        public IActionResult ObtenerProductoPorId(int id)
        {
            var producto = _gestor.ObtenerProductoPorId(id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // POST: api/productos
        [HttpPost]
        public IActionResult AgregarProducto([FromBody] Producto producto)
        {
            _gestor.AgregarProducto(producto);
            return Ok("Producto agregado correctamente");
        }

        // PUT: api/productos/5
        [HttpPut("{id}")]
        public IActionResult ActualizarProducto(int id, [FromBody] Producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productoExistente = _gestor.ObtenerProductoPorId(id);

            if (productoExistente == null)
            {
                return NotFound();
            }

            producto.Id = id;

            _gestor.ActualizarProducto(producto);

            return Ok("Producto actualizado correctamente");
        }

        // DELETE: api/productos/5
        [HttpDelete("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            var productoExistente = _gestor.ObtenerProductoPorId(id);

            if (productoExistente == null)
            {
                return NotFound();
            }

            _gestor.EliminarProducto(id);

            return Ok("Producto eliminado correctamente");
        }

        // GET: api/productos/buscar/nombre/arroz
        [HttpGet("buscar/nombre/{nombre}")]
        public IActionResult BuscarPorNombre(string nombre)
        {
            var productos = _gestor.BuscarProductosPorNombre(nombre);

            return Ok(productos);
        }

        // GET: api/productos/buscar/categoria/lacteos
        [HttpGet("buscar/categoria/{categoria}")]
        public IActionResult BuscarPorCategoria(string categoria)
        {
            var productos = _gestor.BuscarProductosPorCategoria(categoria);

            return Ok(productos);
        }
    }
}
