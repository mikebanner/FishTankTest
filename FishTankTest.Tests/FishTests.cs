namespace FishTankTest.Tests;

public class FishTests
{
    [Fact]
    public void GoldfishReturnsCorrectName()
    {
        var fish = new Goldfish("Bob Marley");

        var result = fish.GetName();
        
        Assert.Equal("Bob Marley", result);
    }
}