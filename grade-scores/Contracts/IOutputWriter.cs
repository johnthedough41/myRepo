using System.Collections.Generic;

namespace gradescores.Contracts
{
    interface IOutputWriter
    {
        void WriteToFileAndDisplay(List<DataEntry> sortedList, string inputFilename);
    }
}
