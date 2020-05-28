using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Common
{
    public class FunctionsException : Exception
    {
        public FunctionsException(string message)
        : base(message)
        {
        }
    }
}
