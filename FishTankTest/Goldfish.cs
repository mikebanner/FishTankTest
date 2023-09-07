namespace FishTankTest;

public class Goldfish : IFeedableFish
{
    private readonly decimal _feedWeight;
    private readonly string _fishName;
    public Goldfish(decimal feedWeight, string name)
    {
        _feedWeight = feedWeight;
        _fishName = name;
    }
    public decimal GetFeedAmount()
    {
        return _feedWeight;
    }

    public string GetName()
    {
        return _fishName;
    }
}