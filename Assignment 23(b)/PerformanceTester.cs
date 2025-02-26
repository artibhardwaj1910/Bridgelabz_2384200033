public class PerformanceTester
{
    public void LongRunningTask() => System.Threading.Thread.Sleep(3000);
}

[TestFixture]
public class PerformanceTests
{
    private PerformanceTester _tester;

    [SetUp]
    public void Setup()
    {
        _tester = new PerformanceTester();
    }

    [Test, Timeout(2000)]
    public void LongRunningTask_ShouldFailIfTakesTooLong()
    {
        _tester.LongRunningTask();
    }
}

