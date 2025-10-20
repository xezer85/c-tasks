using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculation calc = new Calculation();

            Console.WriteLine("Kalkulyatora xoş gəlmisiniz!");
            Console.Write("Birinci ədədi daxil edin: ");
            string input1 = Console.ReadLine();
            double num1 = Convert.ToDouble(input1);

            Console.Write("İkinci ədədi daxil edin: ");
            string input2 = Console.ReadLine();
            double num2 = Convert.ToDouble(input2);

            Console.Write("Əməliyyatı daxil edin (+, -, *, /): ");
            string opInput = Console.ReadLine();
            char operation = opInput[0];

            try
            {
                double result = calc.Calculate(num1, num2, operation);
                Console.WriteLine("Nəticə: {0} {1} {2} = {3}", num1, operation, num2, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xəta: " + ex.Message);
            }

            Console.WriteLine("Çıxmaq üçün bir düymə basın...");
            Console.ReadKey();
        }
    }
}
