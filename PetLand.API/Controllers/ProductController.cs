using Microsoft.AspNetCore.Mvc;
using static PetLand.DAL.Entities.Product;
using PetLand.BAL.Models;
using PetLand.DAL.Entities;
using DAL.Infrastructure;
using PetLand.BAL.Services.Interfaces;

namespace PetLand.API.Controllers;
[Route("api/[controller]/action")]
[ApiController]

public class ProductController : Controller
{
    Product initProduct = new Product();
    List<Product> products = new List<Product>();
    private readonly IProductService _productService;
    private readonly IUnitOfWork _unitOfWork;
  
    public ProductController(IProductService productService, IUnitOfWork unitOfWork)
    {
        _productService = productService;
        _unitOfWork = unitOfWork;
    }

    #region GetProduct
    /// <summary>
    /// Get all products
    /// </summary>
    /// <param name="keywords">Search by name produce</param>
    /// <param name="PAGE_SIZE">size of product</param>
    /// <param name="page">page</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<ProductViewModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetProductAsync([FromQuery] string? keywords, [FromQuery] List<string>? sortBy, int PAGE_SIZE, int page = 1)
    {
        var result = _productService.GetAll(keywords, sortBy, PAGE_SIZE, page);
        return new JsonResult(new
        {
            result
        });
    }
    #endregion
}
