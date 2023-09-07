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
}