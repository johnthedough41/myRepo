using gradescores;
using gradescores.Contracts;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace UnitTests
{
    [TestFixture]
    public class InputParserTest
    {
        IInputParser _inputParser;
        string InputFilename;
        
        List<DataEntry> Expected = new List<DataEntry>
        {
            new DataEntry(){LastName="BUNDY,", FirstName="TERESSA,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="ALLAN,", Grade="70"},
            new DataEntry(){LastName="AKING,", FirstName="MADISON,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="FRANCIS,", Grade="70"},
        };

        [SetUp]
        public void Init()
        {
            var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            InputFilename = dir + "\\SampleInput.txt";
            _inputParser = new InputParser();
        }
        [TearDown]
        public void CleanUp()
        {
            _inputParser = null;
        }

        [Test]
        public void When_parse_is_invoked()
        {
            var result = _inputParser.Parse(InputFilename);

            Assert.AreEqual(Expected, result);
        }
    }
}
