using Calculator.Core.Entities;
using Calculator.Test.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Test.IntegrationTests.Persistence
{
    public class HistoryContextTest : ContextHandleTestBase
    {
        [Fact]
        public async Task SaveChangesAsync_ShouldCreateNewData()
        {
            var historic = new History { HistoryId = 10, CalcHistory = "5 + 5 = 10" };
            historyContext.Histories.Add(historic);

            await historyContext.SaveChangesAsync();
            historic.HistoryId.Equals(5);
        }
    }
}
