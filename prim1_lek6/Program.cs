// See https://aka.ms/new-console-template for more information
using prim1_lek6.Class;

var calc = new Calculator(5, 2);
Console.WriteLine($"a+b={calc.Add()} a-b={calc.Subtrackt()}" +
    $" a*b={calc.Multiple()} a/b= {calc.Divide()}");

ITaxCalculator taxcalc= new Calculator(5, 2);
Console.WriteLine($"a+b={taxcalc.Add()} a-b={taxcalc.Subtrackt()}");
