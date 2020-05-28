using Calculator.Core.Commands;
using Calculator.Core.Common;
using Calculator.Infrastructure.Database;
using Calculator.Test.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Calculator.Test.UnitTests.Application
{
    public class CalculatorFunctionsCommandTest : ContextHandleTestBase
    {
        private readonly CalculatorFunctionsCommandHandler calculatorFunctionsCommandHandler;
        public CalculatorFunctionsCommandTest()
        {
            calculatorFunctionsCommandHandler = new CalculatorFunctionsCommandHandler(historyContext);
        }

        [Theory]
        [InlineData(37.60, 98, 135.6)]
        [InlineData(5, 35, 40)]
        [InlineData(-69, 8, -61)]
        [InlineData(-9, -5, -14)]
        [InlineData(0, 5, 5)]
        public void GivenTwoNumbers_ShouldSumThem(Decimal number1, Decimal number2, Decimal expected)
        {
            Assert.Equal(expected, calculatorFunctionsCommandHandler.HandleSum(number1, number2));
        }

        [Theory]
        [InlineData(37.60, 98, -60.4)]
        [InlineData(5, 35, -30)]
        [InlineData(-69, 8, -77)]
        [InlineData(-9, -5, -4)]
        [InlineData(0, 5, -5)]
        public void GivenTwoNumbers_ShouldSubThem(Decimal number1, Decimal number2, Decimal expected)
        {
            Assert.Equal(expected, calculatorFunctionsCommandHandler.HandleSub(number1, number2));
        }

        [Theory]
        [InlineData(37.60, 98, 3684.8)]
        [InlineData(5, 35, 175)]
        [InlineData(-69, 8, -552)]
        [InlineData(-9, -5, 45)]
        [InlineData(0, 5, 0)]
        public void GivenTwoNumbers_ShouldMultThem(Decimal number1, Decimal number2, Decimal expected)
        {
            Assert.Equal(expected, calculatorFunctionsCommandHandler.HandleMult(number1, number2));
        }

        [Theory]
        [InlineData(180, 4, 45)]
        [InlineData(5, 10, 0.5)]
        [InlineData(-100, 8, -12.5)]
        [InlineData(-10, -2, 5)]
        [InlineData(0, 5, 0)]
        public void GivenTwoNumbers_ShouldDivThem(Decimal number1, Decimal number2, Decimal expected)
        {
            Assert.Equal(expected, calculatorFunctionsCommandHandler.HandleDiv(number1, number2));
        }

        [Theory]
        [InlineData(10, 0)]
        public void GivenTwoNumbers_ShouldException(Decimal number1, Decimal number2)
        {
            Assert.Throws<Exception>(() => calculatorFunctionsCommandHandler.HandleDiv(number1, number2));

        }

    }
}
