using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContext
{
    public class CustomerServiceContext:DbContext,IContext
    {
        private readonly string _connection;

        public CustomerServiceContext(string options)
        {
            _connection = options;
        }

        // מימוש ה-DbSets מהממשק
        public DbSet<Company> Companies { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<Call> Calls { get; set; }
        public DbSet<CallParticipantAnalysis> CallParticipantAnalyses { get; set; }
        public DbSet<Score> Scores { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connection);
        }

    }
}
