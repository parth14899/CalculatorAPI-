using CalculatorAPI.Controllers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;


using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // Add method: Handles a GET request and returns the sum of two numbers
        [HttpGet("add")]
        public IActionResult Add([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a + b);
        }

        // Subtract method: Handles a GET request and returns the difference of two numbers
        [HttpGet("subtract")]
        public IActionResult Subtract([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a - b);
        }

        // Multiply method: Handles a GET request and returns the product of two numbers
        [HttpGet("multiply")]
        public IActionResult Multiply([FromQuery] decimal a, [FromQuery] decimal b)
        {
            return Ok(a * b);
        }

        // Divide method: Handles a GET request and returns the quotient of two numbers
        [HttpGet("divide")]
        public IActionResult Divide([FromQuery] decimal a, [FromQuery] decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            return Ok(a / b);
        }

        // Modulo method: Handles a GET request and returns the remainder of two numbers
        [HttpGet("modulo")]
        public IActionResult Modulo([FromQuery] decimal a, [FromQuery] decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Modulo by zero is not allowed.");
            }
            return Ok(a % b);
        }
    }
}

