using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionController : Controller
    {
        // GET api/positon
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "xxxxxx", "yyyyyy" };
        }
    }
}