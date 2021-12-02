using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avg_word_length
{
    public class ErrorResponse
    {
        public string errorMessage { get; set; }
        public bool isError { get; set; }
        public int statusCode { get; set; }
        
    }
}
