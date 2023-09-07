using NuGet.Frameworks;

namespace FishTankTest.Tests;

public class FishTankTests
{
    [Fact]
    public void EmptyFishTankReturnsZeroWeightOfFeed()
    {
        var sut = new FishTank();

        var result = sut.Feed();
        
        Assert.Equal(0, result);
    }

    [Fact]
    public void FishTankWithSingleGoldfishReturnsCorrectFeedWeight()
    {
        var sut = new FishTank();

        sut.AddFish(new Goldfish(0.1));
        
        var result = sut.Feed();
        
        Assert.Equal(0.1, result);
    }
    
    [Fact]
    public void FishTankWithTwoGoldfishReturnsCorrectFeedWeight()
    {
        var sut = new FishTank();

        sut.AddFish(new Goldfish(0.1));
        sut.AddFish(new Goldfish(0.1));
        
        var result = sut.Feed();
        
        Assert.Equal(0.2, result);
    }
}