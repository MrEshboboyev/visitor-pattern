using Microsoft.AspNetCore.Mvc;
using Infrastructure.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ProductService _productService;

    public ProductController()
    {
        _productService = new ProductService();
    }

    [HttpPost("apply-discounts")]
    public IActionResult ApplyDiscounts()
    {
        _productService.ApplyDiscounts();
        return Ok("Discounts applied.");
    }

    [HttpPost("apply-taxes")]
    public IActionResult ApplyTaxes()
    {
        _productService.ApplyTaxes();
        return Ok("Taxes applied.");
    }
}
