using System;
using System.IO;

namespace gradescores
{
    public class Program
    {
        static void Main (string[] args)
        {
            try
            {
                if (args.Length == 0)
                {
                    Console.WriteLine("Please input a file name.");
                    return;
                }
                var inputParser = new InputParser();
                var listSorter = new ListSorter();
                var outputWriter = new OutputWriter();
                var list = inputParser.Parse(args[0]);
                var sortedList = listSorter.Sort(list);
                outputWriter.WriteToFileAndDisplay(sortedList, args[0]);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File does not exist.");
                return;
            }
        }
    }
}
