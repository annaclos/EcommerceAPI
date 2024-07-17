using ecommerceApi.Model;
using ecommerceApi.src.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace ecommerceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController(ICategoriaService _service) : Controller
    {

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("list")]
        public async Task<ActionResult> List()
        {
            try
            {
                return Ok(await _service.List());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Categoria categoria)
        {
            try
            {
                return Ok(await _service.Create(categoria));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Categoria categoria)
        {
            try
            {
                return Ok(await _service.Update(categoria));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
