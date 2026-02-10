using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CallParticipantAnalysisRepository : IRepository<CallParticipantAnalysis>
    {

        private readonly IContext ctx;
        public  CallParticipantAnalysisRepository(IContext context)
        {
            this.ctx = context;
        }
        public async Task<CallParticipantAnalysis> AddAsync(CallParticipantAnalysis item)
        {
            ctx.CallParticipantAnalyses.Add(item);
            ctx.SaveChangesAsync();
            return item;
        }

        public async Task DeleteAsync(int id)
        {
            await ctx.CallParticipantAnalyses.Where(x => x.ParticipantId == id).ExecuteDeleteAsync();
        }

        public async Task<IEnumerable<CallParticipantAnalysis>> GetAllAsync()
        {
           return await ctx.CallParticipantAnalyses.ToListAsync();
        }

        public async Task<CallParticipantAnalysis> GetByIdAsync(int id)
        {
            return await ctx.CallParticipantAnalyses.FirstOrDefaultAsync(x => x.ParticipantId == id);

        }

        public async Task<CallParticipantAnalysis> UpdateAsync(int id, CallParticipantAnalysis item)
        {
            ctx.CallParticipantAnalyses.Update(item);
            await ctx.SaveChangesAsync();
            return item;
        }

    }
}
