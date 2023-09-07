using FishTankTest.FishTypes;

namespace FishTankTest;

public class FishTank
{
    private readonly IList<IFeedableFish> _fish = new List<IFeedableFish>();
    
    public decimal Feed()
    {
        var totalFeedWeight = 0.0m;
        
        foreach (var fish in _fish)
        {
            totalFeedWeight += fish.GetFeedAmount();
        }
        
        return totalFeedWeight;
    }

    public void AddFish(IFeedableFish fish)
    {
        _fish.Add(fish);
    }
}