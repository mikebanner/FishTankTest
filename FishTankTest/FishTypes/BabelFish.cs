namespace FishTankTest.FishTypes;

public class BabelFish : IFeedableFish
{
    private readonly string _fishName;
    private readonly decimal _feedWeight;
    public BabelFish(string name)
    {
        _fishName = name;
        _feedWeight = 0.3m;
    }

    public decimal GetFeedAmount() => _feedWeight;
    public string GetName() => _fishName;
}