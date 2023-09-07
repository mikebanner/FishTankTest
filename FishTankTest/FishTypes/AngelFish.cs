namespace FishTankTest.FishTypes;

public class AngelFish : IFeedableFish
{
    private readonly string _fishName;
    private readonly decimal _feedWeight;
    public AngelFish(string name)
    {
        _fishName = name;
        _feedWeight = 0.2m;
    }

    public decimal GetFeedAmount() => _feedWeight;

    public string GetName() => _fishName;
 
}