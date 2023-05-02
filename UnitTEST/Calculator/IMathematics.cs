using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface IMathematics
    {
        int Sum(int a, int b);
        int Subtract(int a, int b);
        int Multiply(int a, int b);
        double Divide(double a, int b);
        int Mod(int a, int b);
        int Factorial(int a);
        int Fibonacci_Get_N_Element(int a);
    }
}
