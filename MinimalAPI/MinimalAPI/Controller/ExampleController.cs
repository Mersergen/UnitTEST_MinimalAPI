using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models;

namespace MinimalAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public string[] GetNames()
        {
            return new string[] { "Ali", "Veli", "Ayşe", "Eda", "Emre" };
        }
    }
}
