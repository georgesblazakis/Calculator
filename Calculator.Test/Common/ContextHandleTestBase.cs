using Calculator.Core.Entities;
using Calculator.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator.Test.Common
{
    public class ContextHandleTestBase
    {
        public HistoryContext historyContext;

        public ContextHandleTestBase()
        {
            var options = new DbContextOptionsBuilder<HistoryContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new HistoryContext(options);
            context.Database.EnsureCreated();

            context.History.AddRange(new[] {
                new History { HistoryId = 5, CalcHistory = "5 + 5 = 10"},
                new History { HistoryId = 6, CalcHistory = "10 + 5 = 15"},
                new History { HistoryId = 7, CalcHistory = "15 + 5 = 20"}
            });
            context.SaveChanges();
            historyContext = context;
        }
    }
}
