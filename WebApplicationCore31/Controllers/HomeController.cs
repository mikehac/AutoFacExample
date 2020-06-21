using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore31.Interfaces;

namespace WebApplicationCore31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        IService1 _service1;
        IService2 _service2;

        public HomeController(IService1 service1, IService2 service2)
        {
            _service1 = service1;
            _service2 = service2;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            var s1 = _service1.GetValue();
            var s2 = _service2.GetAnotherValue();
            return Ok(string.Format("s1={0}, s2={1}. \n", s1, s2));
        }
    }
}