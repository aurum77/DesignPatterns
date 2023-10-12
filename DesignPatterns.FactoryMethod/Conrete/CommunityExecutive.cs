using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Conrete;

public class CommunityExecutive : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine("asking about community building");
    }
}
