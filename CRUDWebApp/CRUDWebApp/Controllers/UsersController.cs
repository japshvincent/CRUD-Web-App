using System.Collections.Generic;
using CRUDWebApp.IService;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _userService.GetUsers();
        }

        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return _userService.GetUserById(id);
        }

        [HttpPost]
        public void SaveOrUpdate([FromForm] User user)
        {
            if (user.UserId == 0) _userService.Save(user);
            else _userService.Update(user);
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _userService.Delete(id);
        }
    }
}
