using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public interface ICalculation
    {
        double Calculate(double x, double y, char op);
    }
}

