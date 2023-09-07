namespace FishTankTest;

public class Goldfish : IFeedableFish
{
    private readonly decimal _feedWeight;
    public Goldfish(decimal feedWeight)
    {
        _feedWeight = feedWeight;
    }
    public decimal GetFeedAmount()
    {
        return _feedWeight;
    }
}