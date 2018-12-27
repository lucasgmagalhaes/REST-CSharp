using Api.Arquitetura.Controllers;
using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("users")]
    public class UserController : BasicController<User>
    {
        public UserController() : base(new UserRepository()) { }
    }
}
