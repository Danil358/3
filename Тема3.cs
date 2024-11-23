using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tema3;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hot func = new Hot();

            func.HelloWorld("Данил");
            func.Surname("Коваленко");
            Console.ReadLine();



            Calculator calc = new Calculator();
            Console.WriteLine($"3 + 3 = {calc.Add(3, 3)}");
            Console.WriteLine($"3 - 3 = {calc.Subtract(3, 3)}");
            Console.WriteLine($"3 * 3 = {calc.Multiply(3, 3)}");
        }
        
            
        
    }
}
