using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Test
{
    
    public class CalculatorTest
    {
        [Fact]
        public void TestAdd()
        {
            //Arrange
            int number1 = 10, number2 = 20;
            int expected = 30, actual = 0;
            //Act
            actual = Calcolator.Add(number1,number2);
            //Assert
            Assert.Equal(expected,actual);
        }
    }
}
