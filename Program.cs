using System;
using classes.Math;

namespace classes
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person pat = new Person();
            pat.FirstName = "pat";
            pat.LastName = "will";
            pat.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
