using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Common
{
    public interface ICalculatorFunctionsCommandHandler
    {
        decimal HandleSum(decimal n1, decimal n2);
        decimal HandleSub(decimal n1, decimal n2);
        decimal HandleMult(decimal n1, decimal n2);
        decimal HandleDiv(decimal n1, decimal n2);

    }
}
