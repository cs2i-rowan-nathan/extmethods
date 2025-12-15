using Dummy;

namespace TestProject1;

[TestClass]
public class Test2
{
    [TestMethod]
    public void TestFirstLetter()
    {
        var s = "Lorem Ipsum";
        Assert.AreEqual("L", s.FirstLetter());
    }

    [TestMethod]
    public void TestFirstLetterEmptyString()
    {
       
        Assert.AreEqual("", "".FirstLetter());
        
    }
}
