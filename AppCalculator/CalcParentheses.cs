using ConsoleApps.CalculatorApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.CalculatorApplication
{
    internal class CalcParentheses : CalcPart
    {
        public CalcParentheses(string input) : base(input)
        {

        }

        public override double GetOutput()
        {
            return new Calculator().Calculate(GetInput());
        }
    }
}
