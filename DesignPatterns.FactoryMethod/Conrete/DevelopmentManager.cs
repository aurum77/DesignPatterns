using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Conrete;

public class DevelopmentManager : HiringManager
{
    protected override IInterviewer MakeInterviewer()
    {
        return new Developer();
    }
}
