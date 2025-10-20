using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculation : ICalculation
    {
        public double Calculate(double a, double b, char operation)
        {
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new DivideByZeroException("İkinci ədəd (b) sıfır ola bilməz bölmə əməliyyatında.");
                    }
                    return a / b;
                default:
                    throw new ArgumentException($"Naməlum əməliyyat simvolu: {operation}");
            }
        }
    }
}
