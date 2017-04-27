using gradescores.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace gradescores
{
    public class ListSorter : IListSorter
    {
        public List<DataEntry> Sort(List<DataEntry> entries)
        {
            return entries.OrderByDescending(e=>e.Grade).
                ThenBy(e=>e.LastName).
                ThenBy(e=>e.FirstName).
                ToList();
        }

    }
}
