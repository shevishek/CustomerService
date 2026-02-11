using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallParticipantAnalysisController : ControllerBase
    {
        private readonly IRepository<CallParticipantAnalysis> repository;

        public CallParticipantAnalysisController(IRepository<CallParticipantAnalysis> repository)
        {
            this.repository = repository;
        }

        // GET: api/<CallParticipantAnalysisController>
        [HttpGet]
        public async Task<IEnumerable<CallParticipantAnalysis>> Get()
        {
            return await repository.GetAllAsync();
        }

        // GET api/<CallParticipantAnalysisController>/5
        [HttpGet("{id}")]
        public async Task<CallParticipantAnalysis> Get(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        // POST api/<CallParticipantAnalysisController>
        [HttpPost]
        public async Task Post([FromBody] CallParticipantAnalysis callParticipantAnalysis)
        {
            await repository.AddAsync(callParticipantAnalysis);
        }

        // PUT api/<CallParticipantAnalysisController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] CallParticipantAnalysis callParticipantAnalysis)
        {
            await repository.UpdateAsync(id,callParticipantAnalysis);
        }

        // DELETE api/<CallParticipantAnalysisController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await repository.DeleteAsync(id);
        }
    }
}
