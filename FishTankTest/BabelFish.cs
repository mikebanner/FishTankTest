namespace FishTankTest;

public class BabelFish : IFeedableFish
{
    private readonly string _fishName;
    private readonly decimal _feedWeight;
    public BabelFish(string name)
    {
        _fishName = name;
    }
    public decimal GetFeedAmount()
    {
        throw new NotImplementedException();
    }

    public string GetName() => _fishName;
}