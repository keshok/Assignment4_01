using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.Write("This program will simulate the rolling of two dice (randomly), and it will also ");
            Console.WriteLine("display how many times each result (sum of both dies) was rolled :)");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to begin...");
            Console.WriteLine();
            Console.ReadKey();

            Random rnd = new Random();

            int[] totaldie = new int[13];

            for (int roll = 0; roll < 36000; roll++)
            {
                totaldie[rnd.Next(1, 7) + rnd.Next(1, 7)]++;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("++++++++++++++++++++++++++");
            Console.Write("+    ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0}{1,12}", "Face", "Frequency");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   +");
            Console.WriteLine("--------------------------");
            Console.ResetColor();

            int throws = 0;

            for (int face = 2; face < totaldie.Length; face++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("+    ");
                Console.ResetColor();
                Console.Write("{0,4}{1,11}", face, totaldie[face]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("    +");
                Console.ResetColor();
                throws += totaldie[face];
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************");
            Console.Write("+     ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Total =  {0}", throws);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    +");
            Console.WriteLine("**************************");
            Console.ResetColor();

            Thread.Sleep(3000);

            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to exit...");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.ReadKey();
        }
    }
}
