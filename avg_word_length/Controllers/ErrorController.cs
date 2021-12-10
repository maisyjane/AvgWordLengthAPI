using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avg_word_length.Controllers
{
    [Route("/error")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
       [HttpGet]
        public ErrorResponse Get()
        {
            Response.Headers.Add("Content-Type", "application/json");
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.StatusCode = 404;

            //contstructor
            return new ErrorResponse
            {
                error = "true",
                statusCode = 404,
                text = "404 not found",
                answer = 0
            };



        }
    }
}
