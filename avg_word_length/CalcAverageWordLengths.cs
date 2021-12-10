using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avg_word_length
{
    public class CalcAverageWordLengths
    {
        public static string AverageWordLength(string input_text)
        {
            string url_parameter = input_text;
            string[] words = url_parameter.Split(' ');
            List<string> wordList = new List<string>(words);
            int initial_size = wordList.Count();
            //only include valid words in the average word length
            bool invalidWord;
            for(int i = 0; i < wordList.Count; i++)
            {
                invalidWord = false;
                foreach (char c in wordList[i].ToCharArray())
                {
                  
                    if (!char.IsLetter(c)) { invalidWord = true; break; }

                }
                if (invalidWord) { wordList.RemoveAt(i); }
            }
           
            double averageLength;
            if (wordList.Count != 0) { averageLength = Math.Round(wordList.Average(w => w.Length)); }
            else { averageLength = 0; }
            
            string value = averageLength.ToString();
            //if (wordList.Count() < initial_size) { return "Average Length for valid words only: " + value; }
            //else { return value;  }
            return value;
        }
    }
}
