using ConnectMySql.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConnectMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MySqlController : ControllerBase
    {

        private readonly LineBotApiPracticeContext _context;

        public MySqlController(LineBotApiPracticeContext context)
        {
            _context = context;
        }

        // GET: api/<MySqlController>
        [HttpGet]
        public IEnumerable<Linebot> Get()
        {
            return _context.Linebots.ToList();
        }

        // GET api/<MySqlController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MySqlController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MySqlController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MySqlController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("Webhook")]
        public IActionResult Webhook()
        {
            return Ok();
        }
    }
}
