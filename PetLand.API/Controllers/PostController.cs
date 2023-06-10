using DAL.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using PetLand.BAL.Models;
using PetLand.BAL.Services.Implements;
using PetLand.BAL.Services.Interfaces;
using PetLand.DAL.Entities;

namespace PetLand.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]

public class PostController : Controller
{
    Post initPost = new Post();
    List<Post> posts = new List<Post>();
    private readonly IUnitOfWork _unitOfWork;

    public PostController( IUnitOfWork unitOfWork)
    {
       
        _unitOfWork = unitOfWork;
    }

    #region EditPost
    /// <summary>
    /// UC10-006
    /// Edit Post's information
    /// </summary>
    /// <remarks>
    ///     Sample request:
    ///
    ///         {
    ///           "PostID": 2,
    ///           
    ///         }
    ///         
    /// </remarks>
    /// <returns>An edited post in the system</returns>
    /// <response code="200">Return posts </response>
    /// <response code="400">If the list is null</response>
    [HttpPut]
    [ProducesResponseType(typeof(PostViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> EditPosttAsync([FromBody] PostViewModel post)
    {
        string errorMessage = "";
        bool status = true;
        var result = new PostViewModel();

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

    #region CreatePost
    /// <summary>
    /// UC10-002
    /// Add a new Post 
    /// </summary>
    /// <remarks>
    ///     Sample request:
    ///
    ///         {
    ///           
    ///           "status": 1,
    ///           "idRole": 2
    ///         }
    ///               
    /// </remarks>
    /// <returns>A new post in the system</returns>
    /// <response code="200">Return Post list</response>
    /// <response code="404">If the list is null</response>
    [HttpPost]
    [ProducesResponseType(typeof(List<PostViewModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AddNewPostAsync([FromBody] PostViewModel post)
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

    #region GetPost
    /// <summary>
    /// Get all posts
    /// </summary>
    /// <param name="keywords">Search by name post</param>
    /// <param name="PAGE_SIZE">size of Post</param>
    /// <param name="page">page</param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(List<PostViewModel>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPostAsync([FromQuery] string? keywords, [FromQuery] List<string>? sortBy, int PAGE_SIZE, int page = 1)
    {
       
        return new JsonResult(new
        {
           
        });
    }
    #endregion

    #region DeletePost
    /// <summary>
    /// UC10-009
    /// Delete selected Post
    /// </summary>
    /// <param name="PostID"></param>
    /// <remarks>
    ///     Sample request:
    ///
    ///         {
    ///           "PostID" : 4
    ///         }
    ///          
    /// </remarks>
    /// <returns>Return result of action and error message (if any)</returns>
    /// <response code="200">Successful message</response>
    /// <response code="404">post is null</response>
    [HttpDelete("{PostId}")]
    [ProducesResponseType(typeof(PostViewModel), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePostAsync(long id)
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

}

