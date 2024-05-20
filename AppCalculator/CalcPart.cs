using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.CalculatorApplication
{
    abstract class CalcPart
    {
        private string input = "";
        public CalcPart(string input)
        {
            SetInput(input);
        }

        public void SetInput(string input)
        {
            this.input = input;
        }

        public string GetInput()
        {
            return input;
        }

        public abstract double GetOutput();
    }
}
