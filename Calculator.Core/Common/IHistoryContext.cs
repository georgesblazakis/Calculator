using Calculator.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Common
{
    public interface IHistoryContext
    {
        public DbSet<History> Histories { get; set; }
        Task<int> SaveChangesAsync();
    }
}
