using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLiveTest
{
    class Program
    {
        static void Main(string[] args)
        {
            LiveTest liveTest = new LiveTest();
            var reverseStr = liveTest.ReverseString("abcdef");
            Console.WriteLine("Reverse Test: " + reverseStr + "");
            Console.ReadLine();
            liveTest.printStr();
            Console.ReadLine();


        }
        public class LiveTest
        {

            public string ReverseString(string str)
            {
                string Temp = "";
                int i, j;
                for (j = 0, i = str.Length - 1; i >= 0; i--, j++)
                {

                    Temp += str[i];
                }
                return Temp;

            }

            public void printStr()
            {
                int num = 100;
                while (num <= 100)
                {
                    if (num % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                        Console.ReadLine();
                    }
                    if (num % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                        Console.ReadLine();
                    }
                    if ((num % 3 == 0) && (num % 5 == 0))
                    {
                        Console.WriteLine("fizzbuzz");
                        Console.ReadLine();
                    }
                    num++;
                }
                

            }

        }

    }
}
