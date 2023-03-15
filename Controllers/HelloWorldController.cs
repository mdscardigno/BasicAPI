using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]//ANNOTATION TO INDICATE THE SPECIFICS OF THE URL
        public string SayHello()
        {
            return $"Hello World!. It is {DateTime.Now} now.";
        }
    }
}
