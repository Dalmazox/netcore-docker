using System.Collections.Generic;
using Koshy.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Koshy.API.Controllers
{
    [Route("v1/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IEnumerable<User> List()
            => Koshy.Domain.Entities.User.GetList();
    }
}