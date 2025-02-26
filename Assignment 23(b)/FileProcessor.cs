public class FileProcessor
{
    public void WriteToFile(string filename, string content) => File.WriteAllText(filename, content);

    public string ReadFromFile(string filename) => File.ReadAllText(filename);
}

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor _fileProcessor;
    private string _testFile = "testfile.txt";

    [SetUp]
    public void Setup()
    {
        _fileProcessor = new FileProcessor();
    }

    [Test]
    public void WriteToFile_ShouldCreateFile()
    {
        _fileProcessor.WriteToFile(_testFile, "Hello World");
        Assert.IsTrue(File.Exists(_testFile));
    }

    [Test]
    public void ReadFromFile_ShouldReturnCorrectContent()
    {
        File.WriteAllText(_testFile, "Hello NUnit");
        Assert.AreEqual("Hello NUnit", _fileProcessor.ReadFromFile(_testFile));
    }
}

