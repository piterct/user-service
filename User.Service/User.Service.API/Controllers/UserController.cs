using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace User.Service.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
    }
}
