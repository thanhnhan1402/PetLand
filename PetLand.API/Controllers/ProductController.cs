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

    #region EditProduct
    /// <summary>
    /// UC10-006
    /// Edit Product's information
    /// </summary>
    /// <remarks>
    ///     Sample request:
    ///
    ///         {
    ///           "ProductID": 5,
    ///           "ProductName": "meo di hia",
    ///           
    ///           "CategoryID": 1
    ///         }
    ///         
    /// </remarks>
    /// <returns>An edited product in the system</returns>
    /// <response code="200">Return products </response>
    /// <response code="400">If the list is null</response>
    [HttpPut]
    [ProducesResponseType(typeof(ProductViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> EditProductAsync([FromBody] ProductViewModel product)
    {
        string errorMessage = "";
        bool status = true;
        var result = new ProductViewModel();
       
        try
        {
            
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
        }
        return Ok(new
        {
            status = status,
            ErrorMessage = errorMessage
        });
    }
    #endregion

    #region CreateProduct
    /// <summary>
    /// UC10-002
    /// Add a new product 
    /// </summary>
    /// <remarks>
    ///     Sample request:
    ///
    ///         {
    ///           "ProductName": "Meo 7 mau",
    ///           "Label": "null",
    ///           "imageProduct": "null",
    ///           "Descreption": "1 chu meo de thuong va hien lanh có màu lông 7 màu"
    ///           "status": 1,
    ///           "idRole": 2
    ///         }
    ///               
    /// </remarks>
    /// <returns>A new Product in the system</returns>
    /// <response code="200">Return Product list</response>
    /// <response code="404">If the list is null</response>
    [HttpPost]
    [ProducesResponseType(typeof(List<ProductViewModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AddNewProdductAsync([FromBody] ProductViewModel product)
    {
        string errorMessage = "";
        bool status = true;

       
        try
        {
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
        }

        return Ok(new
        {
            Status = status,
            ErrorMessage = errorMessage
        });
    }
    #endregion

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

    #region DeleteProduct
    /// <summary>
    /// UC10-009
    /// Delete selected Product
    /// </summary>
    /// <param name="ProductID"></param>
    /// <remarks>
    ///     Sample request:
    ///
    ///         {
    ///           "ProductID" : 4
    ///         }
    ///          
    /// </remarks>
    /// <returns>Return result of action and error message (if any)</returns>
    /// <response code="200">Successful message</response>
    /// <response code="404">Product is null</response>
    [HttpDelete("{ProductId}")]
    [ProducesResponseType(typeof(ProductViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteProductAsync(long id)
    {
        string errorMessage = "";
        bool status = false;
        try
        {
            
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
        }
        return new JsonResult(new
        {
            status = status
        });
    }
    #endregion

    #region ChangleProductCategory
    /// <summary>
    /// UC10-005
    /// Change the Product's category
    /// </summary>
    /// <param name="ProductID"></param>
    /// <param name="ProductID"></param>
    /// 
    /// <remarks>
    ///     Sample request:
    ///
    ///         {
    ///           "ProductID": 2,
    ///           "ProductID": 1
    ///         }
    ///         
    /// </remarks>
    /// 
    /// <response code="200">Return Products </response>
    /// <response code="400">If the list is null</response>
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(ProductViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> ChangeProductCategoryAsync(long id, long IdRole)
    {
        string errorMessage = "";
        bool status = false;
        var result = new ProductViewModel();
        try
        {
            status = true;
        }
        catch (Exception ex)
        {
            errorMessage = ex.Message;
        }
        return Ok(new
        {
            status = status,
            result = result,
            ErrorMessage = errorMessage
        });
    }
    #endregion
}
