using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avg_word_length.Controllers
{
    [Route("/")]
    [ApiController]
    public class AvgWordLengthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            string text = "Invalid String";
            string result = "N/A";
            return BadRequest(new { Text = text, AverageWordLength = result, StatusCode = "400" });

        }

        [HttpGet("{text}")]
        public IActionResult AverageWordLength(string text)
        {
            try
            {
                double result = CalcAverageWordLengths.AverageWordLength(text);
                return Ok(new { Text = text, AverageWordLength = result, StatusCode = "200" });
            }
            catch (Exception ex)
            {
                text = "Invalid Arguments";
                string result = "N/A";
                return BadRequest(new { Text = text, AverageWordLength = result, StatusCode = "400", Error = ex });

            }

        }
    }
}
