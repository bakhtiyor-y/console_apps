using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.CalculatorApplication
{
    abstract class CalcOperator
    {
        public abstract char GetOperatorChar();
        public abstract int GetPririty();
        public abstract double Calculate(double value1, double value2);
    }
}
