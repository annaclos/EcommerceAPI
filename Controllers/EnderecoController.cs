using ecommerceApi.Model;
using ecommerceApi.src.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace ecommerceApi.Controllers;

[ApiController]
[Route ("api/[controller]")]

public class EnderecoController(IEnderecoService _endereco) : ControllerBase
{
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
		try
		{
			return Ok(await _endereco.Delete(id));
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
			return Ok(await _endereco.Get(id));
		}
		catch (Exception e)
		{
			return BadRequest(e.Message);
		}
	}

	[HttpPost]
	public async Task<ActionResult> Create([FromBody] Endereco endereco)
	{
		try
		{
			return Ok(await _endereco.Create(endereco));
		}
		catch (Exception e)
		{
			return BadRequest(e.Message);
		}
	}

	[HttpPut]
	public async Task<ActionResult> Update([FromBody] Endereco endereco)
	{
		try
		{
			return Ok(await _endereco.Update(endereco));
		}
		catch (Exception e)
		{
			return BadRequest(e.Message);
		}
	}

    [HttpGet("List")]
   public async Task<ActionResult> List()
	{
		try
		{
			return Ok(await _endereco.List());
		}
		catch (Exception e)
		{
			return BadRequest(e.Message);
		}
	}
}


