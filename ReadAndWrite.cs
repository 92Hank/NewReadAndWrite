using System;
using System.IO;
using System.Collections.Generic;

namespace NewReadAndWrite
{
    public class ReadAndWrite
    {
        public List<string> names = new List<string>();
        public void WriteToFile()
        {
            Console.WriteLine("\t Enter a name you want to add: ");
            string name = Console.ReadLine();

            names.Add(name);
            Console.WriteLine("\t You entered: ");
            Console.WriteLine("\t " + name);

            using (var writer = File.AppendText($"disknames.txt"))
            {
                writer.WriteLine(name);
            }
            Console.ReadLine();
        }

        public void ReadToFile()
        {
            using (var reader = File.OpenText($"disknames.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var savedName = line;
                    names.Add(savedName);
                    line = reader.ReadLine();
                }

                Console.WriteLine(line);
            }
        }

        public void ListNames()
        {
            Console.WriteLine("\t All names from namn2.txt:");
            Console.WriteLine();

            foreach (var allNames in names)
            {
                Console.WriteLine("\t " + allNames);
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}