using Calculator;

int s1 = 5, s2 = 2, result = 0;

Mathematics m = new Mathematics();

Console.WriteLine("SUM: " + m.Sum(s1, s2));
Console.WriteLine("SUBSTRACT: " + m.Subtract(s1, s2));
Console.WriteLine("MULTIPLY: " + m.Multiply(s1, s2));
Console.WriteLine("DIVIDE: " + m.Divide(s1, s2));
Console.WriteLine("MOD: " + m.Mod(s1, s2));
Console.WriteLine("FACTORIAL: " + m.Factorial(s1));
Console.WriteLine("FIBO: " + m.Fibonacci_Get_N_Element(10));

m.SUM2(s1,s2,out result);
Console.WriteLine("Result:"+result);