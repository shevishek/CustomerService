using Microsoft.AspNetCore.Mvc;
using Repository.Entities;
using Repository.Interfaces;
using Common.Dto;
using Service.Interfaces;
using Service.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerService.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorController : ControllerBase
    {
        private readonly IRepository<Operator> repository;
        private readonly IsExist<OperatorDto> _isExist; 
        //private readonly IAuthService _authService;

        // כאן אנחנו מקבלים את הכל מהמערכת
        public OperatorController(IRepository<Operator> repository, IsExist<OperatorDto> isExist)//, IAuthService authService
        {
            this.repository = repository;
            this._isExist = isExist;
            //this._authService = authService;
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

        [HttpPost("/login")]
        public IActionResult Login([FromBody] Login loginData)
        {
            // 1. בדיקה מול ה-Repository שהמשתמש קיים (דילגתי על זה לצורך הדוגמה)
            var o= _isExist.Exist(loginData);
            // 2. אם המשתמש תקין - קוראים לסרביס לייצר טוקן
            var token = GenerateToken(loginData);//, "User"
            return Ok(new { token = token });
        }
    }
}
