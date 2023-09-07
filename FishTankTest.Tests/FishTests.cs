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
    public void AngelfishReturnsCorrectName()
    {
        var fish = new AngelFish("Angelica");

        var result = fish.GetName();
        
        Assert.Equal("Angelica", result);
    }

    [Fact]
    public void AngelFishReturnsCorrectWeightOfFood()
    {
        var sut = new AngelFish("Angelica");

        var result = sut.GetFeedAmount();

        Assert.Equal(0.2m, result);
    }
}