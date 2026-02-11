using AutoMapper;
using Common.Dto;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Repository.Entities;
using Repository.Interfaces;
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

    public class CallParticipantAnalysisService
    {
        private readonly IRepository<CallParticipantAnalysis> repository;
        private readonly IMapper mapper;
        private readonly IConfiguration _configuration;
        public readonly IsExist<CallParticipantAnalysisDto> isExist;

        public CallParticipantAnalysisService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

       

        
    }
}
