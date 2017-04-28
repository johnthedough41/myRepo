using gradescores;
using gradescores.Contracts;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class OutputWriterTest
    {
        private OutputWriter _outputWriter;
        private string _inputFilename;
        private string _directory;
        private List<DataEntry> _sampleList = new List<DataEntry>
        {
            new DataEntry(){LastName="BUNDY,", FirstName="TERESSA,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="ALLAN,", Grade="70"},
            new DataEntry(){LastName="AKING,", FirstName="MADISON,", Grade="88"},
            new DataEntry(){LastName="SMITH,", FirstName="FRANCIS,", Grade="70"},
        };

        [SetUp]
        public void Init()
        {
            _directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _inputFilename = _directory + "\\SampleInput.txt";
            Directory.SetCurrentDirectory(_directory);
            _outputWriter = new OutputWriter();
        }

        [TearDown]
        public void CleanUp()
        {
            _outputWriter = null;
        }

        [Test]
        public void When_write_to_file_and_display_is_invoked()
        {
            _outputWriter.WriteToFileAndDisplay(_sampleList, _inputFilename);

            var reader = new StreamReader(_inputFilename);
            var inputFile = reader.ReadToEnd();
            reader.Close();

            reader = new StreamReader(_directory + "\\SampleInput-graded.txt");
            var outputfile = reader.ReadToEnd();
            reader.Close();

            Assert.AreEqual(inputFile,outputfile);
        }
    }
}
