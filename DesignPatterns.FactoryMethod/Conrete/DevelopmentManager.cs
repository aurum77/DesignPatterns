using DesignPatterns.FactoryMethod.Conrete;

namespace DesignPatterns.FactoryMethod.Abstract;

public class DevelopmentManager : HiringManager
{
    protected override IInterviewer MakeInterviewer()
    {
        return new Developer();
    }
}
