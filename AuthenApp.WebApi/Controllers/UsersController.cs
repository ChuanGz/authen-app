using Microsoft.AspNetCore.Mvc;

namespace AuthenApp.WebApi;

[ApiController]
public class UsersController : ControllerBase
{

    [HttpGet]
    public List<ApplicationUser> Gets()
    {
        return new List<ApplicationUser>();
    }
}