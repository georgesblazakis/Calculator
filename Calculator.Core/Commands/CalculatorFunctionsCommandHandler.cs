using Calculator.Core.Common;
using Calculator.Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Core.Commands
{
    public class CalculatorFunctionsCommandHandler : ICalculatorFunctionsCommandHandler
    {
        private readonly IHistoryContext historyContext;
        public CalculatorFunctionsCommandHandler(IHistoryContext _historyContext)
        {
            historyContext = _historyContext;
        }

        public decimal HandleSum(decimal n1, decimal n2)
        {
            try
            {
                var calc = new CalculatorDomain();
                var result = calc.Sum(n1, n2);
                historyContext.Histories.Add(new History() { CalcHistory = $"{n1} + {n2} = {result}" });
                return result; 
            }
            catch (Exception)
            {
                throw new FunctionsException(string.Format("Error: {0} + {1}", n1, n2));
            }

        }
        public decimal HandleSub(decimal n1, decimal n2)
        {
            try
            {
                var calc = new CalculatorDomain();
                var result = calc.Sub(n1, n2);
                historyContext.Histories.Add(new History() { CalcHistory = $"{n1} - {n2} = {result}" });
                return result;
            }
            catch (Exception)
            {
                throw new FunctionsException(string.Format("Error: {0} - {1}", n1, n2));
            }
        }
        public decimal HandleMult(decimal n1, decimal n2)
        {
            try
            {
                var calc = new CalculatorDomain();
                var result = calc.Mult(n1, n2);
                historyContext.Histories.Add(new History() { CalcHistory = $"{n1} * {n2} = {result}" });
                return result;
            }
            catch (Exception)
            {
                throw new FunctionsException(string.Format("Error: {0} * {1}", n1, n2));
            }
        }
        public decimal HandleDiv(decimal n1, decimal n2)
        {
            try
            {
                if(n2 == 0)
                    throw new FunctionsException(string.Format("Error"));

                var calc = new CalculatorDomain();
                var result = calc.Div(n1, n2);
                historyContext.Histories.Add(new History() { CalcHistory = $"{n1} / {n2} = {result}" });
                return result;

            }
            catch (Exception)
            {
                throw new FunctionsException(string.Format("Error: {0} / {1}", n1, n2));
            }
        }


    }
}
