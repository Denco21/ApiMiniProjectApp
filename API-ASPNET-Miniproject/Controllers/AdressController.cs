using API_ASPNET_Miniproject.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_ASPNET_Miniproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressController : ControllerBase
    { 

        private ILogger<AdressController> _logger;
        public AdressController(ILogger<AdressController> logger)
        {
            _logger = logger;
            
        }
        // GET: api/<AdressController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AdressController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AdressController>
        [HttpPost]
        public void Post([FromBody] Adress data)
        {
            _logger.LogInformation("Den här adressen är inloggade som {Adress}", data);

        }

        // PUT api/<AdressController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AdressController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
