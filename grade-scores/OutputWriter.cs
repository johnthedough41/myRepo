using System.Collections.Generic;
using System.Linq;
using gradescores.Contracts;
using System.IO;
using System;

namespace gradescores
{
    public class OutputWriter : IOutputWriter
    {
        public void WriteToFileAndDisplay(List<DataEntry> sortedList, string inputFilename)
        {
            var outputFilename = inputFilename + "-graded.txt";
            var outputFile = new StreamWriter(outputFilename);

            foreach (var line in sortedList)
            {
                var outputString = line.LastName + line.FirstName + line.Grade;
                outputFile.WriteLine(outputString);
                Console.WriteLine(outputString);
            }
            outputFile.Close();
            Console.WriteLine("Finished: created " + outputFilename);
        }
    }
}
