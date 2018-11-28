using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace readifyknockknock2.Controllers
{
    [Route("api")]
    [ApiController]
    public class ReadifyKnocKnockController : ControllerBase
    {
        [Route("Token")]
        public ActionResult<Guid> GetToken()
        {
            return new Guid("8f3b7fdb-2d0a-4b7f-a461-a2e2d55d5104");
        }

        [Route("Fibonacci")]
        public ActionResult<Int64> CalculateFibonacci([FromQuery(Name = "n")] long n)
        {
            return -1;
        }

        [Route("ReverseWords")]
        public ActionResult<string> ReverseWords([FromQuery(Name = "sentence")] string sentence)
        {
            return "...";
        }

        [Route("TriangleType")]
        public ActionResult<string> GetTriangleType([FromQuery(Name = "a")] int a, [FromQuery(Name = "b")] int b, [FromQuery(Name = "c")] int c)
        {
            return "Error";
        }
    }
}
