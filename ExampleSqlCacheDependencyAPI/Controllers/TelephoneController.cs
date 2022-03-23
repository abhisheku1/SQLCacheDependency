using ExampleSqlCacheDependencyAPI.Business;
using ExampleSqlCacheDependencyAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleSqlCacheDependencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelephoneController : ControllerBase
    {
        private readonly ITelephoneManager _telephoneManager;


        public TelephoneController(ITelephoneManager telephoneManager)
        {
            _telephoneManager = telephoneManager;

        }

        [HttpPost("Add")]
        public IActionResult Add(Telephone telephone)
        {

            var result = _telephoneManager.TelehoneAddAsync(telephone);
            if (result.IsCompletedSuccessfully)
            {

                return Ok();
            }
            return BadRequest();

        }
    }
}
