using Calculator.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Commands
{
    public class CalculatorFunctionsCommandHandler 
    {
        private readonly IHistoryContext historyContext;
        public CalculatorFunctionsCommandHandler(IHistoryContext _historyContext)
        {
            historyContext = _historyContext;
        }

        public decimal HandleSum(decimal n1, decimal n2)
        {
            return n1 + n2;
        }
        public decimal HandleSub(decimal n1, decimal n2)
        {
            return n1 - n2;
        }
        public decimal HandleMult(decimal n1, decimal n2)
        {
            return n1 * n2;
        }
        public decimal HandleDiv(decimal n1, decimal n2)
        {
            return n1 + n2;
        }


    }
}
