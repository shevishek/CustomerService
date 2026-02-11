using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IRepository<Company> repository;

        public CompanyController(IRepository<Company> repository)
        {
            this.repository = repository;
        }
        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<IEnumerable<Company>> Get()
        {
            return await repository.GetAllAsync() ;
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<Company> Get(int id)
        {
            return await repository.GetByIdAsync(id);
        }

        // POST api/<CompanyController>
        [HttpPost]
        public async Task Post([FromBody] Company company)
        {
            await repository.AddAsync(company);
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Company company)
        {
            await repository.UpdateAsync(id, company);
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await repository.DeleteAsync(id);
        }
    }
}
