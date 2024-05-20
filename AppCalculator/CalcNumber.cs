using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.CalculatorApplication
{
    internal class CalcNumber : CalcPart
    {
        public CalcNumber(string input) : base(input)
        {
        }

        public override double GetOutput()
        {
            return double.Parse(GetInput());
        }
    }
}
