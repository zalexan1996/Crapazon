using Microsoft.AspNetCore.Mvc;

namespace CZ.API.Features.Test;

[ApiController]
[Route("v1/[controller]")]
public class TestController : ControllerBase
{
    [HttpPost("[action]")]
    public ActionResult<string> GetMotd()
    {
        return Ok("Sell your crap; buy more crap.");
    }
}