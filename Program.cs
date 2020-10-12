using System;
using System.IO;
using System.Collections.Generic;

namespace NewReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadAndWrite input = new ReadAndWrite();


            string isRunning = "0";
            while (isRunning != "q")
            {
                Console.Clear();

                Console.WriteLine("\t _____________________");
                Console.WriteLine("\t |----TheNameList----|");
                Console.WriteLine("\t |[1]. Enter name    |");
                Console.WriteLine("\t |[2]. List all names|");
                Console.WriteLine("\t |[Q]. for Quit      |");
                Console.WriteLine("\t |---Select option---|");
                Console.WriteLine("\t |-------1 - 2-------|");
                Console.WriteLine("\t |___________________|");

                isRunning = Console.ReadLine();
                Console.WriteLine();

                switch (isRunning.ToUpper())
                {
                    case "1":
                        input.WriteToFile();
                        input.ReadToFile();
                        break;
                    case "2":
                        input.ListNames();
                        break;
                    case "Q":
                        Console.WriteLine("\t The program ends here...");
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("\t This option was incorrect!");
                        Console.WriteLine("\t Press enter to continue");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
