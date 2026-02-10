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
    public class CompanyRepository : IRepository<Company>
    {

        private readonly IContext ctx;
        public CompanyRepository(IContext context)
        {
            this.ctx = context;
        }
        public async Task<Company> AddAsync(Company item)
        {
            ctx.Companies.Add(item);
            ctx.SaveChangesAsync();
            return item;
        }

        public async Task DeleteAsync(int id)
        {
            await ctx.Companies.Where(x => x.CompanyId == id).ExecuteDeleteAsync();
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await ctx.Companies.ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            return await ctx.Companies.FirstOrDefaultAsync(x => x.CompanyId == id);

        }

        public async Task<Company> UpdateAsync(int id, Company item)
        {
            ctx.Companies.Update(item);
            await ctx.SaveChangesAsync();
            return item;
        }

    }

}
