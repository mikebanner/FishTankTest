namespace FishTankTest;

public class FishTank
{
    private IList<Goldfish> _fish = new List<Goldfish>();
    
    public double Feed()
    {
        var totalFeedWeight = 0.0;
        
        foreach (var fish in _fish)
        {
            totalFeedWeight += fish.GetFeedAmount();
        }
        
        return totalFeedWeight;
    }

    public void AddFish(Goldfish fish)
    {
        _fish.Add(fish);
    }
}