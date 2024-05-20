using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.CalculatorApplication
{
    internal class CalcMultiply : CalcOperator
    {
        public override double Calculate(double value1, double value2)
        {
            return value1 * value2;
        }

        public override char GetOperatorChar()
        {
            return '*';
        }

        public override int GetPririty()
        {
            return 6;
        }
    }
}
