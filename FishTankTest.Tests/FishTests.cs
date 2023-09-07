using FishTankTest.FishTypes;

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
    
    [Fact]
    public void BabelfishReturnsCorrectName()
    {
        var fish = new BabelFish("Babylon");

        var result = fish.GetName();
        
        Assert.Equal("Babylon", result);
    }
    
    [Fact]
    public void BabelFishReturnsCorrectWeightOfFood()
    {
        var sut = new BabelFish("Babylon");

        var result = sut.GetFeedAmount();

        Assert.Equal(0.3m, result);
    }
}