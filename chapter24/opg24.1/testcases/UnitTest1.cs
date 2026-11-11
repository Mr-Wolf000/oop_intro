namespace testcases;

public class Tests
{
    Pin pin;
    [SetUp]
    public void Setup(){
        pin = new Pin();
    }

    [Test]
    public void Test1()
    {
        Assert.That(pin.Expend(351), Is.EqualTo(true));
    }
    
    [Test]
    public void Test2()
    {
        Assert.That(pin.Expend(350), Is.EqualTo(false));
    }
    
    [Test]
    public void Test3()
    {
        Assert.That(pin.Expend(0), Is.EqualTo(false));
        Assert.That(pin.Expend(0), Is.EqualTo(false));
        Assert.That(pin.Expend(0), Is.EqualTo(false));
        Assert.That(pin.Expend(0), Is.EqualTo(true));
    }

    [Test]
    public void Test4()
    {
        Assert.AreEqual(true, pin.Expend(500));
    }
}
