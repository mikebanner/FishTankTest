namespace FishTankTest;

public class Goldfish : IFeedableFish
{
    private readonly double _feedWeight;
    public Goldfish(double feedWeight)
    {
        _feedWeight = feedWeight;
    }
    public double GetFeedAmount()
    {
        return _feedWeight;
    }
}