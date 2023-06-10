using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetLand.BAL.Models;
using System.Security.Claims;

namespace PetLand.API.Controllers;
[Route("api/[controller]/[action]")]
[ApiController]

public class AuthController : Controller
{
    public AuthController ()
    {
        
    }
    #region Login
    /// <summary>
    /// UC0-001
    /// Log into system using email and password
    /// </summary>    
    /// <remarks>
    ///     Sample request:
    ///
    ///         {
    ///           "email": "superadmin@fsoft.com",
    ///           "password": "superadmin"
    ///         }
    ///         
    /// </remarks>
    /// <returns>Specific HTTP Status code</returns>
    /// <response code="200">Return home screen if the access is successful</response>
    /// <response code="400">If the account is null</response>
    [HttpPost]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Boolean), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> LoginAsync([FromBody] AccountViewModel account)
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

        return Ok(new
        {
            Status = status,
            
        });
    }
    #endregion

    #region Logout
    /// <summary>
    /// UC0-005
    /// Log out system
    /// </summary>   
    /// <returns>Specific HTTP Status code</returns>
    /// <response code="204">Return login page</response>
    [Authorize]
    [HttpDelete]
    public async Task<IActionResult> LogoutAsync()
    {
        //Response.Cookies.Delete("jwt", new CookieOptions
        //{
        //    HttpOnly = true,
        //    SameSite = SameSiteMode.None,
        //    Secure = true
        //});
        //return NoContent();
        //var userName = HttpContext.User.FindFirstValue(ClaimTypes.Name);
        //if (userName == null)
        //{
        //    return Unauthorized();
        //}
        //if (await _userService.InvalidateAccessToken(userName))
        //{
        //    return NoContent();
        //}
        string rawUserId = HttpContext.User.FindFirstValue("Id");

        if (!long.TryParse(rawUserId, out long id))
        {
            return Unauthorized();
        }

        

        return NoContent();
    }
    #endregion  
}
