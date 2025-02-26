public class ListManager
{
    public void AddElement(List<int> list, int element) => list.Add(element);

    public void RemoveElement(List<int> list, int element) => list.Remove(element);

    public int GetSize(List<int> list) => list.Count;
}


NUnit Test Cases
[TestFixture]
public class ListManagerTests
{
    private ListManager _listManager;
    private List<int> _list;

    [SetUp]
    public void Setup()
    {
        _listManager = new ListManager();
        _list = new List<int>();
    }

    [Test]
    public void AddElement_ShouldIncreaseSize()
    {
        _listManager.AddElement(_list, 10);
        Assert.AreEqual(1, _listManager.GetSize(_list));
    }

    [Test]
    public void RemoveElement_ShouldDecreaseSize()
    {
        _list.Add(10);
        _listManager.RemoveElement(_list, 10);
        Assert.AreEqual(0, _listManager.GetSize(_list));
    }

    [Test]
    public void GetSize_ShouldReturnCorrectSize()
    {
        _list.Add(5);
        _list.Add(15);
        Assert.AreEqual(2, _listManager.GetSize(_list));
    }
}

