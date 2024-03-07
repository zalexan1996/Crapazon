using Microsoft.AspNetCore.Mvc;

namespace CZ.API.Account;

[ApiController]
[Route("v1/[controller]")]
public class AccountController : ControllerBase
{
    [HttpPost()]
    [Route("[action]")]
    public ActionResult<bool> Login(int id)
    {
        return Ok(true);
    }
}