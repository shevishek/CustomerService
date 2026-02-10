using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public class OperatorRepository : IRepository<Operator>
    {

        private readonly IContext ctx;
        public OperatorRepository(IContext context)
        {
            this.ctx = context;
        }
        public async Task<Operator> AddAsync(Operator item)
        {
            ctx.Operators.Add(item);
            ctx.SaveChangesAsync();
            return item;
        }

        public async Task DeleteAsync(int id)
        {
            await ctx.Operators.Where(x => x.OperatorId == id).ExecuteDeleteAsync();
        }

        public async Task<IEnumerable<Operator>> GetAllAsync()
        {
            return await ctx.Operators.ToListAsync();
        }

        public async Task<Operator> GetByIdAsync(int id)
        {
            return await ctx.Operators.FirstOrDefaultAsync(x => x.OperatorId == id);

        }

        public async Task<Operator> UpdateAsync(int id, Operator item)
        {
            ctx.Operators.Update(item);
            await ctx.SaveChangesAsync();
            return item;
        }

    }
}
