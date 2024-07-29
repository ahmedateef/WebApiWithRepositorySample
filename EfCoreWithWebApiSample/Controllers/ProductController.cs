using WebApiWithRepositorySample.Model;
using WebApiWithRepositorySample.Service;
using Microsoft.AspNetCore.Mvc;

namespace WebApiWithRepositorySample.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult<GetAllProductResponse> GetAll()
    {
        var response = _productService.GetAllProducts();
        return Ok(response);
    }

    [HttpPost]
    public ActionResult Post([FromBody] AddProductRequest reqModel)
    {
        _productService.AddProduct(reqModel);
        return Ok();
    }
}
}
