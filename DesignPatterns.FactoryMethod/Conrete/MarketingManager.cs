using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Conrete;

public class MarketingManager : HiringManager
{
    protected override IInterviewer MakeInterviewer()
    {
        return new CommunityExecutive();
    }
}
