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


        //קבלת פרטי שיחה ווליום אורך צפיפות
        //public async Task<List<CompanyDto>> setDetails(Call call)
        //{
        //    Console.WriteLine("נתוני שיחה טלפנית");
        //    var (avgVolume, peakVolume) = VolumeAnalyzer.Analyze("agent.wav");
        //    Console.WriteLine($"ווליום ממוצע (RMS): {avgVolume:0.000}");
        //    Console.WriteLine($"ווליום מקסימלי (Peak): {peakVolume:0.000}");
        //    var duration = VolumeAnalyzer.GetDuration("agent.wav");
        //    Console.WriteLine($"אורך השיחה: {duration}");
        //    int wordCount = speakerTexts["Guest-1"].Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        //    double wordsPerSecond = wordCount / duration.TotalSeconds;
        //    Console.WriteLine($"צפיפות שיחה: {wordsPerSecond}");
        //}

    }
}
