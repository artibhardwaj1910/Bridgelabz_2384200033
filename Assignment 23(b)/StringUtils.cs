public class StringUtils
{
    public string Reverse(string str) => new string(str.Reverse().ToArray());

    public bool IsPalindrome(string str) => str.ToLower() == new string(str.ToLower().Reverse().ToArray());

    public string ToUpperCase(string str) => str.ToUpper();
}


NUnit Test Cases
[TestFixture]
public class StringUtilsTests
{
    private StringUtils _utils;

    [SetUp]
    public void Setup()
    {
        _utils = new StringUtils();
    }

    [Test]
    public void Reverse_ShouldReturnReversedString()
    {
        Assert.AreEqual("olleH", _utils.Reverse("Hello"));
    }

    [Test]
    public void IsPalindrome_ShouldReturnTrueForPalindrome()
    {
        Assert.IsTrue(_utils.IsPalindrome("madam"));
    }

    [Test]
    public void IsPalindrome_ShouldReturnFalseForNonPalindrome()
    {
        Assert.IsFalse(_utils.IsPalindrome("hello"));
    }

    [Test]
    public void ToUpperCase_ShouldConvertToUpper()
    {
        Assert.AreEqual("HELLO", _utils.ToUpperCase("hello"));
    }
}

