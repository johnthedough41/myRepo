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
        private IInputParser _inputParser;
        private string _inputFilename;
        
        List<DataEntry> _expected = new List<DataEntry>
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
            _inputFilename = dir + "\\SampleInput.txt";
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
            var result = _inputParser.Parse(_inputFilename);

            Assert.AreEqual(_expected, result);
        }

        [Test]
        public void When_parse_is_invoked_with_nonexistent_file()
        {
            Assert.That(() => _inputParser.Parse("test"),
                Throws.TypeOf<FileNotFoundException>());
        }
    }
}
