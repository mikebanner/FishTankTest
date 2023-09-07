namespace FishTankTest;

public class FishTank
{
    private IList<IFeedableFish> _fish = new List<IFeedableFish>();
    
    public double Feed()
    {
        var totalFeedWeight = 0.0;
        
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