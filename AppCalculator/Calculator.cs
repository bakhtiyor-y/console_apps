
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApps.CalculatorApplication
{
    internal class Calculator
    {
        private double lastResult = 0.0;
        const string OPERATORS = "+-*/";

        public dynamic Calculate(string arithmeticExpression)
        {
            if(arithmeticExpression.Length > 5 && arithmeticExpression.Substring(0, 5) == "Error")
            {
                return arithmeticExpression.Substring(6);
            }
            double result=0.0;
            if (arithmeticExpression.Length <= 1) 
            { 
                double.TryParse(arithmeticExpression, out result); 
                return result; 
            }

            List<CalcOperator> operators = new List<CalcOperator>();
            List<CalcPart> parts = new List<CalcPart>();

            if (OPERATORS.Contains(arithmeticExpression[0])) parts.Add(new CalcNumber(lastResult.ToString()));
            int tempNumberDigit = 0;
            bool addNumber = false;
            for (int i = 0; i < arithmeticExpression.Length; i++)
            {
                if ("0123456789.".Contains(arithmeticExpression[i]))
                {
                    tempNumberDigit++;
                    if (i >= arithmeticExpression.Length - 1) { addNumber = true; i++; }
                }
                else if (tempNumberDigit > 0)
                {
                    addNumber = true;
                }
                else if (arithmeticExpression[i] == '(')
                {
                    int openStartIndex = i;
                    int openBracketsCount = 0;
                    int closeBracketsCount = 0;
                    do
                    {
                        if (arithmeticExpression[i] == '(')
                        {
                            openBracketsCount++;
                        }

                        if (arithmeticExpression[i] == ')')
                        {
                            closeBracketsCount++;
                        }

                        i++;
                    } while (openBracketsCount != closeBracketsCount);

                    parts.Add(new CalcParentheses(arithmeticExpression.Substring(openStartIndex + 1, i - openStartIndex - 2)));
                }
                if (i < arithmeticExpression.Length && OPERATORS.Contains(arithmeticExpression[i]))
                {
                    switch (arithmeticExpression[i])
                    {
                        case '+':
                            operators.Add(new CalcPlus());
                            break;
                        case '-':
                            operators.Add(new CalcMinus());
                            break;
                        case '*':
                            operators.Add(new CalcMultiply());
                            break;
                        case '/':
                            operators.Add(new CalcDivide());
                            break;
                    }

                }
                if (addNumber)
                {
                    string tmpNumber = arithmeticExpression.Substring(i - tempNumberDigit, tempNumberDigit);
                    parts.Add(new CalcNumber(tmpNumber));

                    tempNumberDigit = 0;
                    addNumber = false;
                }
            }

            while (parts.Count > 1)
            {
                List<int> highestOperators = new List<int>();
                for (int i = 0; i < operators.Count; i++)
                {
                    if (highestOperators.Count <= 0) highestOperators.Add(i);
                    else
                    {
                        if (operators[i].GetPririty() > operators[highestOperators[0]].GetPririty())
                        {
                            highestOperators.Clear();
                            highestOperators.Add(i);
                        }
                        else if (operators[highestOperators[0]].GetPririty() == operators[i].GetPririty())
                        {
                            highestOperators.Add(i);
                        }
                    }
                }
                for (int i = 0; i < highestOperators.Count; i++)
                {
                    int currentOperator = highestOperators[i] - i;
                    double currentResult = operators[currentOperator].Calculate(parts[currentOperator].GetOutput(), parts[currentOperator + 1].GetOutput());
                    operators.RemoveAt(currentOperator);
                    parts.RemoveRange(currentOperator, 2);
                    parts.Insert(currentOperator, new CalcNumber(currentResult.ToString()));
                }
            }
            result = parts[0].GetOutput();

            return result;
        } 
    }
}
