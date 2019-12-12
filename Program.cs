using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_4___Random_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

        
            //Generates a random integer with no constraints
            Console.WriteLine("Random integer from 0 to maximum integer");
            Console.WriteLine(generator.Next());
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

            //Generates a random integer from 0 to 10
            Console.WriteLine("Random integer from 0 to 10");
            Console.WriteLine(generator.Next(11));
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

            //Generates a random integer from 1 to 10
            Console.WriteLine("Random integer from 1 to 10");
            Console.WriteLine(generator.Next(1, 11));
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

            //Generates a random integer from -10 to 0
            Console.WriteLine("Random integer from -10 to 0");
            Console.WriteLine(generator.Next(-10, 1));
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

            //Generates a random double from 0 to 1
            Console.WriteLine("Random double from 0 to 1");
            Console.WriteLine(generator.NextDouble());
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();

            //Generates a random double from 0 to 5
            Console.WriteLine("Random double from 0 to 5");
            Console.WriteLine(generator.NextDouble() * 5);
            Console.WriteLine("Hit ENTER to continue");
            Console.ReadLine();


        }
    }
}
