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
    public class AdditionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Addtion(int num1,int num2)
        {
            var result = num1 + num2;
            return Ok(result);
        }

      
       
    }
}
