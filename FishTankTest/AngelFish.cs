using System.Drawing;

namespace FishTankTest;

public class AngelFish : IFeedableFish
{
    private readonly string _fishName;
    private readonly decimal _feedWeight;
    public AngelFish(string name)
    {
        _fishName = name;
        _feedWeight = 0.2m;
    }
    
    public decimal GetFeedAmount()
    {
        return _feedWeight;
    }

    public string GetName()
    {
        throw new NotImplementedException();
    }
}