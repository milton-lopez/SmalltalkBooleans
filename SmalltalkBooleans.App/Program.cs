using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmalltalkBooleans.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = ReadInput();

            //ProcessNumberBefore(number);

            ProcessNumberAfter(number);

            Console.ReadLine();
        }

        private static void ProcessNumberAfter(int number)
        {
            (number % 3 == 0).And(number % 5 == 0)
                             .IfTrue(() => Console.WriteLine("Number is divisible by 15"))
                             .IfFalse(() => Console.WriteLine("Number is not divisible by 15"));
        }

        private static void ProcessNumberBefore(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                Console.WriteLine("Number is divisible by 15");
            else
                Console.WriteLine("Number is not divisible by 15");
        }

        private static int ReadInput()
        {
            Console.WriteLine("Enter a number");
            var number = Console.ReadLine();
            return Convert.ToInt32(number);
        }
    }
}
