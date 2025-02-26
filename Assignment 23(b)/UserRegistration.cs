using System;
using System.Text.RegularExpressions;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Username is required.");
        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) throw new ArgumentException("Invalid email format.");
        if (password.Length < 8) throw new ArgumentException("Password must be at least 8 characters long.");
    }
}


NUnit Test Cases
[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration _userRegistration;

    [SetUp]
    public void Setup()
    {
        _userRegistration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInput_ShouldNotThrowException()
    {
        Assert.DoesNotThrow(() => _userRegistration.RegisterUser("JohnDoe", "john@example.com", "Password1"));
    }

    [Test]
    public void RegisterUser_EmptyUsername_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("", "john@example.com", "Password1"));
    }

    [Test]
    public void RegisterUser_InvalidEmail_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "invalid-email", "Password1"));
    }

    [Test]
    public void RegisterUser_ShortPassword_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john@example.com", "short"));
    }
}

