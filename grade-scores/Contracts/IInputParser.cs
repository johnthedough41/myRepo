using System.Collections.Generic;

namespace gradescores.Contracts
{
    public interface IInputParser
    {
        List<DataEntry> Parse(string filename);
    }
}
