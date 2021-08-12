using Microsoft.AspNetCore.Mvc;
using User.Service.Domain.Commands.Result;

namespace User.Service.API.Controllers
{
    public class BaseController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult GetResult(GenericCommandResult result) => StatusCode(result.StatusCode, result);
    }
}
