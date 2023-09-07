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

    [Theory]
    [InlineData(1, 0.1)]
    [InlineData(2, 0.2)]
    [InlineData(20, 2.0)]
    public void FishTankWithGoldfishReturnsCorrectFeedWeight(int numberOfGoldFish, decimal expectedWeight)
    {
        var sut = new FishTank();

        for (int i = 0; i < numberOfGoldFish; i++)
        {
            sut.AddFish(new Goldfish($"James Bond {i}"));
        }

        var result = sut.Feed();
        
        Assert.Equal(expectedWeight, result);
    }
    
    [Theory]
    [InlineData(1, 0.2)]
    [InlineData(2, 0.4)]
    [InlineData(20, 4.0)]
    public void FishTankWithMultipleAngelfishReturnsCorrectFeedWeight(int numberOfFish, decimal expectedWeight)
    {
        var sut = new FishTank();

        for (int i = 0; i < numberOfFish; i++)
        {
            sut.AddFish(new AngelFish($"Angelica {i}"));
        }

        var result = sut.Feed();
        
        Assert.Equal(expectedWeight, result);
    }
    
    [Theory]
    [InlineData(1, 0.3)]
    [InlineData(2, 0.6)]
    [InlineData(20, 6.0)]
    public void FishTankWithMultipleBabelfishReturnsCorrectFeedWeight(int numberOfFish, decimal expectedWeight)
    {
        var sut = new FishTank();

        for (int i = 0; i < numberOfFish; i++)
        {
            sut.AddFish(new BabelFish($"Angelica {i}"));
        }

        var result = sut.Feed();
        
        Assert.Equal(expectedWeight, result);
    }

    [Fact]
    public void FishTankWithSingleFishOfEachTypeReturnsCorrectFeedWeight()
    {
        var sut = new FishTank();
        
        sut.AddFish(new Goldfish("Goldie"));
        sut.AddFish(new AngelFish("Angelica"));
        sut.AddFish(new BabelFish("Babylon"));

        var result = sut.Feed();
        
        Assert.Equal(0.6m, result);
    }
}