using NUnit.Framework;

public class TestGetSomeString
{
    [Test]
    public void GetStringTest()
    {
        const string someString = nameof(someString);
        Assert.AreEqual(someString, GetSomeString.GetString(someString));
    }
}
