using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Conrete;

public class Developer : IInterviewer
{
    public void AskQuestions()
    {
        Console.WriteLine("asking about design patterns");
    }
}
