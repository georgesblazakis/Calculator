using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Core.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorFunctionsController : ControllerBase
    {
        private readonly ICalculatorFunctionsCommandHandler command;

        public CalculatorFunctionsController(ICalculatorFunctionsCommandHandler _command)
        {
            command = _command;
        }

        // POST-SUM: api/CalculatorFunctions:sum
        [HttpPost]
        [Route("Sum")]
        public async Task<IActionResult> Sum(decimal number1, decimal number2)
        {
            return Ok(command.HandleSum(number1, number2)); 
        }

        // POST-SUB: api/CalculatorFunctions
        [HttpPost]
        [Route("Sub")]
        public async Task<IActionResult> Sub(decimal number1, decimal number2)
        {
            return Ok(command.HandleSub(number1, number2));
        }

        // POST-MULT: api/CalculatorFunctions
        [HttpPost]
        [Route("Mult")]

        public async Task<IActionResult> Mult(decimal number1, decimal number2)
        {
            return Ok(command.HandleMult(number1, number2));

        }
        // POST-DIV: api/CalculatorFunctions
        [HttpPost]
        [Route("Div")]
        public async Task<IActionResult> Div(decimal number1, decimal number2)
        {
            return Ok(command.HandleDiv(number1, number2));
            

        }
    }
}
