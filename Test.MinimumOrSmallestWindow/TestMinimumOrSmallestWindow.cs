using MinimumOrSmallestWindow;

namespace Test.MinimumOrSmallestWindow;

public class TestMinimumOrSmallestWindow
{
    private readonly IWindowFinder _windowFinderFinder;

    public TestMinimumOrSmallestWindow()
    {
        _windowFinderFinder = new WindowFinder();
    }
    
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("ADOBECODEBANC","ABC", "BANC")]
    [TestCase("a","a", "a")]
    [TestCase("this is a test string","tist", "t stri")]
    [TestCase("geeksforgeeks","ork", "ksfor")]
    public void ShouldFindTheMinimumWindow(string input, string pattern, string result)
    {
        //Arrange
        
        //Act
        string r = _windowFinderFinder.CalculateWindowByHashing(input, pattern);
        
        //Assert
        Assert.That(result, Is.EqualTo(r));
    }

    [TestCase("a","aa")]
    public void ShouldReturnNoSuchWindowExist(string input, string pattern)
    {
        //Arrange
        
        //Act
        string r = _windowFinderFinder.CalculateWindowByHashing(input, pattern);
        
        //Assert
        Assert.That(r, Is.EqualTo(String.Empty));
    }

}