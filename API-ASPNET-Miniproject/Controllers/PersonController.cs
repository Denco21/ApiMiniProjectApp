using API_ASPNET_Miniproject.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_ASPNET_Miniproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private List<PersonInfo> _data = new List<PersonInfo>();

        private ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
            
        }
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<PersonInfo> Get()
        {
            return _data;
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public PersonInfo Get(int id)
        {
            return _data.FirstOrDefault(p=>p.Id ==id);
        }

        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonInfo data)
        {
            _logger.LogInformation("Den här personen är inloggade som {Person}", data); 
            


        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PersonInfo person)
        {
            PersonInfo existingPerson = _data.FirstOrDefault(p => p.Id == id);
            if (existingPerson != null)
            {
                _data.Remove(existingPerson);
                _data.Add(person);
            }
            else
            {
                // Logga att personen inte kunde hittas
            }
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var person = _data.FirstOrDefault(p => p.Id == id);
            if (person != null)
            {
                _data.Remove(person);
            }
            else
            {
                // Logga att personen inte kunde hittas
            }
        }

    }
}
