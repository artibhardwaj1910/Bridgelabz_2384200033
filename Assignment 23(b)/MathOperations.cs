public class MathOperations
{
    public int Divide(int a, int b)
    {
        if (b == 0) throw new ArithmeticException("Cannot divide by zero.");
        return a / b;
    }
}

[TestFixture]
public class MathOperationsTests
{
    private MathOperations _mathOperations;

    [SetUp]
    public void Setup()
    {
        _mathOperations = new MathOperations();
    }

    [Test]
    public void Divide_ByZero_ShouldThrowException()
    {
        Assert.Throws<ArithmeticException>(() => _mathOperations.Divide(10, 0));
    }
}

