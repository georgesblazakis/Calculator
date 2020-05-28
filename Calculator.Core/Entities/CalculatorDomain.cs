using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Entities
{
    public class CalculatorDomain
    {
        public decimal Sum(decimal n1, decimal n2)
        {
            return decimal.Round((n1) + (n2), 2, MidpointRounding.AwayFromZero);
        }

        public decimal Sub(decimal n1, decimal n2)
        {
            return decimal.Round((n1) - (n2), 2, MidpointRounding.AwayFromZero);
        }

        public decimal Div(decimal n1, decimal n2)
        {
            return decimal.Round((n1) / (n2), 2, MidpointRounding.AwayFromZero);
        }

        public decimal Mult(decimal n1, decimal n2)
        {
            return decimal.Round((n1) * (n2), 2, MidpointRounding.AwayFromZero);
        }

    }
}
