using avg_word_length.Controllers;
using System;
using Xunit;

namespace avg_word_length.Tests
{
    public class AverageWordLengthTests
    {
        //[Fact]
        //public void TestController()
        //{
          //  var controller = new AvgWordLengthController();

        //}

        [Fact]
        public void TestAverageLength()
        {
            double actual_result = CalcAverageWordLengths.AverageWordLength("My name is Maisy");
            double expected_result = 3.25;
            Assert.Equal(expected_result, actual_result);
        }
    }
}
