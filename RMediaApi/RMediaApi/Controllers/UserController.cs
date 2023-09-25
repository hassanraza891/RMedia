using Microsoft.AspNetCore.Mvc;
using RMedia.Data.Entities;

namespace RMediaApi.Controllers
{
    [Route("api/user")]

    public class UserController : Controller
    {
        private readonly RMedia.Service.Users.IUser _user;
        public UserController(RMedia.Service.Users.IUser user)
        {
            _user = user;
        }
        public IActionResult Post(User user)
        {
            try
            {
                var result = _user.CreateUser(user);

                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
