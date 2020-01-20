using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number;
            number = 3;

            const float pi = 3.14f;
            float totalPrice = 20.95f;
            string me = "pat";
            byte lumber = 2;
            Console.WriteLine(lumber + " :byte" + number + " :number" + pi + " :float");
            Console.WriteLine(me + " :string"  + " :number" + pi + " :float");
           
        }

    }
}
