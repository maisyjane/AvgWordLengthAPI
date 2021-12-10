using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avg_word_length
{
    public class ErrorResponse
    {
        public string text { get; set; }
        public string error { get; set; }
        public int statusCode { get; set; }

        public int answer { get; set; }

    }
}
