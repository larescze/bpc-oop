using cv12_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace cv12_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Calculate")]
        public double Post([FromBody] CalculationData data)
        {
            if (data.Operation == "+")
            {
                return data.Operand1 + data.Operand2;
            }
            else if (data.Operation == "-")
            {
                return data.Operand1 - data.Operand2;
            }
            else if (data.Operation == "*")
            {
                return data.Operand1 * data.Operand2;
            }
            else if (data.Operation == "/")
            {
                if (data.Operand2 == 0)
                {
                    return Double.NaN;
                }

                return data.Operand1 / data.Operand2;
            }

            return 0;
        }
    }
}
