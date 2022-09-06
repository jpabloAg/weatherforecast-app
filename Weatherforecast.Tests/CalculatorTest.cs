using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weatherforecast.Domain.Adapters;
using Xunit;

namespace Weatherforecast.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculator_add_test()
        {
            Calculator calculator = new Calculator();
            int number1 = 1;
            int number2 = 9;

            int result = calculator.add(number1, number2);

            Assert.Equal(10, result);
        }

        [Theory]
        [InlineData(10, 7, 3)]
        [InlineData(35, 20, 15)]
        public void Calculator_subtract_test(int number1, int number2, int expected)
        {
            Calculator calculator = new Calculator();

            int result = calculator.subtract(number1, number2);

            Assert.Equal(expected, result);
        }
    }
}
