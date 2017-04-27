using System.Collections.Generic;

namespace gradescores.Contracts
{
    public interface IListSorter
    {
        List<DataEntry> Sort(List<DataEntry> entries);
    }
}
