using GestorEmpleados.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiWebAPI.Data;
using MiWebAPI.Models;

namespace MiWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly ProveedorData _proveedorData;
        public ProveedorController(ProveedorData proveedorData)
        {
            _proveedorData = proveedorData;
        }

        // Método para obtener la lista de provedores filtrada por nombre
        [HttpPost]
        [Route("GetProveedores")]
        public async Task<IActionResult> Lista([FromBody] string filtro)
        {
            List<Proveedor> lista = await _proveedorData.GetProveedores(filtro);
            return StatusCode(StatusCodes.Status200OK, lista, new { isSuccess = respuesta });
        }

        // Método para agregar un nuevo provedor
        [HttpPost]
        [Route("AddProveedor")]
        public async Task<IActionResult> AddProveedor([FromBody] Proveedor objeto)
        {
            var respuesta = await _proveedorData.AddProveedor(objeto);
            return StatusCode(StatusCodes.Status200OK, new { isSuccess = respuesta });
        }

        // Método para actualizar un provedor existente
        [HttpPost]
        [Route("UpdateProveedor")]
        public async Task<IActionResult> UpdateProveedor([FromBody] Proveedor objeto)
        {
            var respuesta = await _proveedorData.UpdateProveedor(objeto);
            return StatusCode(StatusCodes.Status200OK, new { isSuccess = respuesta });
        }

        // Método para eliminar un provedor por Id
        [HttpPost]
        [Route("DeleteProveedor")]
        public async Task<IActionResult> DeleteProveedor([FromBody] int Id)
        {
            var respuesta = await _proveedorData.DeleteProveedor(Id);
            return StatusCode(StatusCodes.Status200OK, new { isSuccess = respuesta });
        }
    }
}
