namespace FishTankTest.Tests;

public class FishTests
{
    [Fact]
    public void GoldfishReturnsCorrectName()
    {
        var fish = new Goldfish(0.1m, "Bob Marley");

        var result = fish.GetName();
        
        Assert.Equal("Bob Marley", result);
    }
}