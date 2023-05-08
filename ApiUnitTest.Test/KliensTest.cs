using ApiSample;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiUnitTest.Test
{
    public class KliensTest
    {
       

  

        [
            Test,
            TestCase("12345", true),
            TestCase("123ad", true),
            TestCase("12Dcs5", false),
            TestCase("85363", true),
            TestCase("attila", true)
            ]

        public void CheckUjAr_InputIsDigit_ReturnsTrue(string input, bool expected)
        {
            // Arrange
            var form = new Form1();

            // Act
            var result = form.CheckUjAr(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}
    
