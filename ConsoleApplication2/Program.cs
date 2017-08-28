using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            string myName = "woo \r\nraymond";
            int myAge = 30;

            Console.WriteLine("Hello World");
            Console.WriteLine("My name is {0}, \nand I am {1:0.00} years old.", myName, myAge);
            Console.ReadKey();
            int a = (int)3.14;
            Console.WriteLine("{0}", a);
            Console.ReadKey();
            */
            /*Console.WriteLine("Please enter the score:");
            string score = Console.ReadLine();
            //int reward;
            if (Convert.ToInt32(score) >= 90)
            {

                Console.WriteLine("reward = {0}", 100);
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("reward = {0}", 0);
                Console.ReadKey();
            }
           */

            /*
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine("Line Number:{0}", a);
                a++;

            }
            Console.ReadKey();
            */
            int j=1;
            do
            {
                Console.WriteLine("Line Number:{0}", j);
                j++;
            }
            while (j <= 0);
            Console.ReadKey();

            Class1.TestClass1();

        }
    }
}
