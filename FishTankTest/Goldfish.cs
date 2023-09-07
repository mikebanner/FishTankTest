namespace FishTankTest;

public class Goldfish : IFeedableFish
{
    private readonly decimal _feedWeight;
    private readonly string _fishName;
    public Goldfish(string name)
    {
        _feedWeight = 0.1m;
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