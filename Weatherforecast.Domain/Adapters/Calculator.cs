using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weatherforecast.Domain.Ports;

namespace Weatherforecast.Domain.Adapters
{
    public class Calculator : ICalculator
    {
        public int add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int subtract(int number1, int number2)
        {
            return number1 - number2;
        }
    }
}
