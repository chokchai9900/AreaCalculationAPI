using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AreaCalculationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriangleController : ControllerBase
    {
        /// <summary>
        /// Area of Triangle.
        /// </summary>

        [HttpGet("{baseoftriangle}/{high}")]
        public ActionResult<string> GetDataForCalculatorTriangleArea(int baseoftriangle, int high)
        {
            var result = (baseoftriangle * high) / 2;
            return $"Area of Triangle : {result}";
        }
    }
}