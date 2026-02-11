using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallController : ControllerBase
    {
        private readonly IRepository<Call> repository;

        public CallController(IRepository<Call> repository)
        {
            this.repository = repository;
        }

        // GET: api/<CallController>
        [HttpGet]
        public async Task<IEnumerable<Call>> Get()
        {
            return await repository.GetAllAsync();
        }

        // GET api/<CallController>/5
        [HttpGet("{id}")]
        public async Task<Call> Get(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        // POST api/<CallController>
        [HttpPost]
        public async void Post([FromBody] Call call)
        {
            await repository.AddAsync(call);
        }

        // PUT api/<CallController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Call call)
        {
            await repository.UpdateAsync(id,call);
        }

        // DELETE api/<CallController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await repository.DeleteAsync(id);
        }
    }
}
