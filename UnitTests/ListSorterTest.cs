using gradescores;
using gradescores.Contracts;
using NUnit.Framework;
using System.Collections.Generic;

namespace UnitTests
{
    [TestFixture]
    public class ListSorterTest
    {
        private ListSorter _listSorter;
        private List<DataEntry> _inputList = new List<DataEntry>
        {
            new DataEntry(){LastName="BUNDY,", FirstName="TERESSA,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="ALLAN,", Grade="70"},
            new DataEntry(){LastName="AKING,", FirstName="MADISON,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="FRANCIS,", Grade="70"},
        };

        private List<DataEntry> _expected = new List<DataEntry>
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
            var result = _listSorter.Sort(_inputList);
            Assert.AreEqual(_expected, result);
        }
    }
}
