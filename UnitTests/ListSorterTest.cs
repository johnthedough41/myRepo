using gradescores;
using gradescores.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class ListSorterTest
    {
        ListSorter _listSorter;
        List<DataEntry> Input = new List<DataEntry>
        {
            new DataEntry(){LastName="BUNDY,", FirstName="TERESSA,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="ALLAN,", Grade="70"},
            new DataEntry(){LastName="AKING,", FirstName="MADISON,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="FRANCIS,", Grade="70"},
        };

        List<DataEntry> Expected = new List<DataEntry>
        {
            new DataEntry(){LastName="AKING,", FirstName="MADISON,", Grade="88"},
            new DataEntry(){LastName="BUNDY,", FirstName="TERESSA,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="ALLAN,", Grade="70"},
            new DataEntry(){LastName="SMITH,", FirstName="FRANCIS,", Grade="70"},
        };

        [SetUp]
        public void Init()
        {
            _listSorter = new ListSorter();
        }
        [TearDown]
        public void CleanUp()
        {
            _listSorter = null;
        }
        [Test]
        public void When_sort_is_invoked()
        {
            var result = _listSorter.Sort(Input);
            Assert.AreEqual(Expected, result);
        }
    }
}
