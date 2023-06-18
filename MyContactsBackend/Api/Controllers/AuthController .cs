using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "";
        }
        [HttpPost]
        public string Post()
        {
            return "";

        }
        [HttpPut]
        public string Put()
        {
            return "";

        }
        [HttpDelete]
        public string Delete()
        {
            return "";

        }
    }



}

