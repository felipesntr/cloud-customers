using CloudCustomers.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            this._usersService = usersService;
        }

        [HttpGet(Name = "GetUsers")]
        public async Task<IActionResult> Get()
        {
            var users = await _usersService.GetAllUsers();
            if (users.Any())
            {
                return Ok(users);
            }

            return NotFound();
        }
    }
}