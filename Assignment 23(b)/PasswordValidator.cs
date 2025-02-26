
using System.Linq;

public class PasswordValidator
{
    public bool IsValidPassword(string password)
    {
        if (string.IsNullOrEmpty(password) || password.Length < 8) return false;
        if (!password.Any(char.IsUpper)) return false;
        if (!password.Any(char.IsDigit)) return false;
        return true;
    }
}


NUnit Test Cases
[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new PasswordValidator();
    }

    [TestCase("Password1", ExpectedResult = true)]
    [TestCase("password", ExpectedResult = false)]
    [TestCase("PASSWORD1", ExpectedResult = true)]
    [TestCase("Pass1", ExpectedResult = false)]
    [TestCase("12345678", ExpectedResult = false)]
    public bool IsValidPassword_ShouldReturnExpectedResult(string password)
    {
        return _validator.IsValidPassword(password);
    }
}

