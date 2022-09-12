using AddingFluent_Validation_toWeb_Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AddingFluent_Validation_toWeb_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeveloperController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(Developer developer)
        {
            return Ok(developer);
        }

    }
}
