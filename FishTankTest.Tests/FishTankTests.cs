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
}