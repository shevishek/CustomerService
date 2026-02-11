using AutoMapper;
//using AutoMapper.Configuration;
using Common.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class OperatorService : IsExist<OperatorDto>,Iservice<OperatorDto>
    {
        private readonly IRepository<Operator> repository;
        private readonly IMapper mapper;
        private readonly IConfiguration _configuration;
        public readonly IsExist<OperatorDto> isExist;

        public OperatorService(IRepository<Operator> repository, IMapper map, IConfiguration configuration, IsExist<OperatorDto> isExist)
        {
            this.repository = repository;
            this.mapper = map;
            this._configuration = configuration;
            this.isExist = isExist;
        }

        public async Task<List<OperatorDto>> GetAllAsync()
        {
            var rep = await repository.GetAllAsync();
            return await mapper.Map<Task<List<OperatorDto>>>(rep);
        }
        public OperatorDto Exist(Login l)
        {
            var op = GetAllAsync().Result.FirstOrDefault(x => x.FirstName == l.FirstName);
            if (op != null)
                return op;
            return null;
        }

        //יצירת טוקן
        private string GenerateToken(OperatorDto op)
        {
            //המפתח להצפנה
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            //אלגוריתם להצפנה
            var credentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
            //אובייקט שמכיל את נתוני המשתמש לפי מפתחות
            var claims = new[] {
            new Claim(ClaimTypes.Email,op.Email),
            new Claim(ClaimTypes.Name,op.FirstName),
            new Claim(ClaimTypes.Email,op.LastName),            
            new Claim(ClaimTypes.Role,"user"),
            //new Claim(ClaimTypes.GivenName,user.GivenName)
            };
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }



        public async Task<OperatorDto> GetByIdAsync(int id) 
        {
            // 1. מחכים לקבל את הישות (Entity) מה-Repository
            var operatorEntity = await repository.GetByIdAsync(id);

            // 2. ממפים את הישות שחזרה ל-DTO (או למה שאת צריכה להחזיר)
            return mapper.Map<OperatorDto>(operatorEntity);
        }
        public async Task<OperatorDto> AddAsync(OperatorDto item) 
        {
            var operatorEntity = await repository.AddAsync(mapper.Map<Operator>(item));

            // 2. ממפים את הישות שחזרה ל-DTO (או למה שאת צריכה להחזיר)
            return mapper.Map<OperatorDto>(operatorEntity);
        }
       public async Task<OperatorDto> UpdateAsync(int id, OperatorDto item) 
        {
            var operatorEntity = await repository.UpdateAsync(id, mapper.Map<Operator>(item));

            // 2. ממפים את הישות שחזרה ל-DTO (או למה שאת צריכה להחזיר)
            return mapper.Map<OperatorDto>(operatorEntity);
        }
       public async Task DeleteAsync(int id) 
        {  
            await DeleteAsync(id);
        }
    }
}