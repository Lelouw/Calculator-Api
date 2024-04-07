using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubstractController : ControllerBase
    {
        [HttpGet]
        public IActionResult Substract(double num1, double num2)
        {
            var result = num1 - num2;
            return Ok(result);
        }

    }
}
