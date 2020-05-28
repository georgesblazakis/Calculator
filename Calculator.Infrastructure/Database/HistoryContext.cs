using Calculator.Core.Common;
using Calculator.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Infrastructure.Database
{
    public class HistoryContext : DbContext, IHistoryContext
    {
        public HistoryContext(DbContextOptions<HistoryContext> options) : base(options) { }
        public DbSet<History> History { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
