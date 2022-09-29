using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);

    class CalculatorClass
    {
        public Formula<double> f;
        private static double answer;

        public double getSum(double input1, double input2)
        {
            answer = input1 + input2;
            return answer;
        }
        public double getDifference(double input1, double input2)
        {
            answer = input1 - input2;
            return answer;
        }
        public double getProduct(double input1, double input2)
        {
            answer = input1 * input2;
            return answer;
        }
        public double getQuotient(double input1, double input2)
        {
            answer = input1 / input2;
            return answer;
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                Console.WriteLine("Removed the Delegate");
            }
        }
    }
}