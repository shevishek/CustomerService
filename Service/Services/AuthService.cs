using AutoMapper;
//using AutoMapper.Configuration;
using Common.Dto;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Service.Interfaces;

namespace Service.Services
{
    public class AuthService:IAuthService
    {
        private readonly IRepository<Operator> _repository;
        private readonly IConfiguration _configuration;
        private readonly CustomerServiceContext _context;


        public AuthService(IRepository<Operator> repository, IConfiguration configuration,CustomerServiceContext context)
        {
            _repository = repository;
            _configuration = configuration;
            _context = context;
        }

        public Operator Exist(Login l)
        {

            var op = _context.Operators.FirstOrDefault(x => x.Mail == l.Email);
            if (op != null)
                return op;
            return null;
        }

        //יצירת טוקן
        public string GenerateToken(Operator op)
        {
            //המפתח להצפנה
            var secret = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            //אלגוריתם להצפנה
            var credentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
            //אובייקט שמכיל את נתוני המשתמש לפי מפתחות
            var claims = new[] {
            new Claim(ClaimTypes.Email,op.Mail),
            new Claim(ClaimTypes.Name,op.FirstName),
            new Claim(ClaimTypes.Email,op.LastName),
            new Claim(ClaimTypes.Role, op.Role.ToString())
            //new Claim(ClaimTypes.GivenName,user.GivenName)
            };
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);

        }     
    }
}
