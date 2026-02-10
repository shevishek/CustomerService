using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallParticipantAnalysisController : ControllerBase
    {
        // GET: api/<CallParticipantAnalysisController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CallParticipantAnalysisController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CallParticipantAnalysisController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CallParticipantAnalysisController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CallParticipantAnalysisController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
