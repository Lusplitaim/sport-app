using Microsoft.AspNetCore.Mvc;
using SportApp.Api.Filters;

namespace SportApp.Api.Controllers
{
    [ApiController]
    [TypeFilter<RestExceptionFilter>]
    [Route("api/[controller]")]
    public abstract class BaseController : ControllerBase
    {
    }
}
