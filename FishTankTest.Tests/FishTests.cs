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

    [Fact]
    public void AngelFishReturnsCorrectWeightOfFood()
    {
        var sut = new AngelFish();

        var result = sut.GetFeedAmount();

        Assert.AreEqual(0.2m, result);
    }
}