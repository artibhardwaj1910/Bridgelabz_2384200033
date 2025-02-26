public class NumberUtils
{
    public bool IsEven(int number) => number % 2 == 0;
}

[TestFixture]
public class NumberUtilsTests
{
    private NumberUtils _utils;

    [SetUp]
    public void Setup()
    {
        _utils = new NumberUtils();
    }

    [TestCase(2, ExpectedResult = true)]
    [TestCase(4, ExpectedResult = true)]
    [TestCase(6, ExpectedResult = true)]
    [TestCase(7, ExpectedResult = false)]
    [TestCase(9, ExpectedResult = false)]
    public bool IsEven_ShouldReturnCorrectResult(int number)
    {
        return _utils.IsEven(number);
    }
}

