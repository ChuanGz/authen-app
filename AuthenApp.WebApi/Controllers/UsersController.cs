using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenApp.WebApi;

[ApiController]
[Route("[controller]/[action]")]
public class UsersController : ControllerBase
{

    [HttpGet]
    public List<ApplicationUser> GetList()
    {
        return new List<ApplicationUser>();
    }

    [Authorize]
    [HttpPatch]
    public ApplicationUser Update()
    {
        return new ApplicationUser();
    }
}