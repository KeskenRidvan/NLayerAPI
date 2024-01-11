using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
	private readonly IProductService _productService;

	public ProductsController(IProductService productService)
	{
		_productService = productService;
	}
	[HttpGet("getall")]
	public IActionResult GetAll()
	{
		var result = _productService.GetAll();

		if (result.Success)
			return Ok(result.Data);

		return BadRequest(result.Message);
	}
}
