namespace FishTankTest.Tests;

public class FishTests
{
    [Fact]
    public void GoldfishReturnsCorrectName()
    {
        var fish = new Goldfish(0.1, "Bob Marley");

        var result = fish.Name;
        
        Assert.Equal("Bob Marley", result);
    }
}