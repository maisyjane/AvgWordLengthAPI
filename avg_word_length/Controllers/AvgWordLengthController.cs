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
        public ErrorResponse Get()
        {
            Response.Headers.Add("Content-Type", "application/json");
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.StatusCode = 404;
            return new ErrorResponse
            {
                text = "404 not found - No parameters supplied",
                error = "true",
                statusCode = 404,
                answer = 0,
                        
             };
        }

        [HttpGet("{input_text}")]
        public IActionResult AverageWordLength(string input_text)
        {
            Response.Headers.Add("Content-Type", "application/json");
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            try
            {
                //checks input is valid
                int letterCounter = 0;
                foreach (char c in input_text.ToCharArray())
                {
                    if (Char.IsLetter(c) && !Char.IsPunctuation(c)) { letterCounter++; }

                }

                if(letterCounter==0)
                {
                    
                    return BadRequest(new { text = "Please Enter words, not numbers", answer = 0, StatusCode = "400", error = "true" });
                }
                else 
                {
                    
                    string converted_result = CalcAverageWordLengths.AverageWordLength(input_text);
                    return Ok(new { text = input_text, answer = converted_result, StatusCode = "200", error = "False" });
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(new { text = "Invalid Arguments: " + ex, answer = 0, StatusCode = "400", error = "true" });

            }

        }
    }
}
