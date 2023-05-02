using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Mathematics : IMathematics
    {
        public double Divide(double a, int b) => a / b;

        public int Factorial(int a)
        {
            int f = 1;
            for (int i = 2; i <= a; i++)
            {
                f *= i;
            }
            return f;
        }

        public int Fibonacci_Get_N_Element(int a)
        {
            //1-1-2-3-5-8-13-21-34-55-89-144-233...
            int s1 = 1, s2 = 1, result = 0;

            for (int i = 0; i < a - 2; i++)
            {
                result = s1 + s2;
                s1 = s2;
                s2 = result;
            }

            return result;
        }

        public int Mod(int a, int b) => a % b;

        public int Multiply(int a, int b) => a * b;

        public int Subtract(int a, int b) => a - b;

        public int Sum(int a, int b) => a + b;

        public void SUM2(int a, int b, out int c) => c = a + b;

    }
}
