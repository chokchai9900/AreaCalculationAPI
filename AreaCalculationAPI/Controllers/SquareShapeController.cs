using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AreaCalculationAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SquareShapeController : ControllerBase
    {
        /// <summary>
        /// Area of Square.
        /// </summary>

        [HttpGet("{side}")]
        public ActionResult<string> GetDataForCalculatorSquareArea(int side)
        {
            var result = side * side;
            return $"Area of square : {result}";
        }

        /// <summary>
        /// Area of Rectangle.
        /// </summary>

        [HttpGet("{width}/{length}")]
        public ActionResult<string> GetDataForCalculatorRectangleArea(int width,int length)
        {
            var result = width * length;
            return $"Area of rectangle : {result}";
        }

        /// <summary>
        /// Area of Parallelogram.
        /// </summary>
        /// 

        [HttpGet("{baseofParallelogram}/{high}")]
        public ActionResult<string> GetDataForCalculatorParallelogramArea(int baseofParallelogram, int high)
        {
            var result = baseofParallelogram * high;
            return $"Area of rectangle : {result}";
        }
    }
}
