using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorController : ControllerBase
    {

        private readonly IRepository<Operator> repository;

        public OperatorController(IRepository<Operator> repository)
        {
            this.repository = repository;
        }
        // GET: api/<OperatorController>
        [HttpGet]
        public async  Task<IEnumerable<Operator>> Get()
        {
            return await repository.GetAllAsync();
        }

        // GET api/<OperatorController>/5
        [HttpGet("{id}")]
        public async Task<Operator> Get(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        // POST api/<OperatorController>
        [HttpPost]
        public async Task Post([FromBody] Operator op)
        {
            await repository.AddAsync(op);
        }

        // PUT api/<OperatorController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Operator op)
        {
            await repository.UpdateAsync(id, op);
        }

        // DELETE api/<OperatorController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await repository.DeleteAsync(id);
        }
    }
}
