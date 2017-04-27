using System.IO;
using gradescores.Contracts;
using System.Collections.Generic;

namespace gradescores
{
    public class InputParser : IInputParser
    {
        public List<DataEntry> Parse(string filename)
        {
            var dataEntryList = new List<DataEntry>();
            string line;
            var reader = File.OpenText(filename);

            while ((line = reader.ReadLine()) != null)
            {
                string[] entry = line.Split(' ');
                var dataEntry = new DataEntry()
                {
                    LastName = entry[0],
                    FirstName = entry[1],
                    Grade = entry[2]
                };
                dataEntryList.Add(dataEntry);
            }
            reader.Close();

            return dataEntryList;
        }
    }
}
