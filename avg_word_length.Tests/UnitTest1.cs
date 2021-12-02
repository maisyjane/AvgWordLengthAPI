using avg_word_length.Controllers;
using System;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace avg_word_length.Tests
{
    public class AverageWordLengthTests
    //makemock server and pass in create factory
    {

        [Fact]
        public void TestAverageLength_correct_parameters()
        {
            string actual_result = CalcAverageWordLengths.AverageWordLength("My name is Maisy");
            string expected_result = "3";
            Assert.Equal(expected_result, actual_result);
        }

        [Fact]
        public void TestAverageLength_incorrect_parameters()
        {
            string actual_result = CalcAverageWordLengths.AverageWordLength("123456");
            string expected_result = "Average Length for valid words only: 0";
            Assert.Equal(expected_result, actual_result);
        }

        [Fact]
        public void TestAverageLength_incorrect_parameters_2()
        {
            string actual_result = CalcAverageWordLengths.AverageWordLength("I have made a spelling erro5");
            string expected_result = "Average Length for valid words only: 4";
            Assert.Equal(expected_result, actual_result);
        }
    }
}
