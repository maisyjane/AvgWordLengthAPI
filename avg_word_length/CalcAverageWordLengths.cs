using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avg_word_length
{
    public class CalcAverageWordLengths
    {
        public static double AverageWordLength(string text)
        {
            string url_parameter = text;
            string[] words = url_parameter.Split(' ');
            double averageLength = words.Average(w => w.Length);
            return averageLength;
        }
    }
}
