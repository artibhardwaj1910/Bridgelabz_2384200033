public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect() => IsConnected = true;

    public void Disconnect() => IsConnected = false;
}

[TestFixture]
public class DatabaseTests
{
    private DatabaseConnection _db;

    [SetUp]
    public void Setup()
    {
        _db = new DatabaseConnection();
        _db.Connect();
    }

    [TearDown]
    public void Teardown()
    {
        _db.Disconnect();
    }

    [Test]
    public void Connection_ShouldBeEstablished()
    {
        Assert.IsTrue(_db.IsConnected);
    }
}

