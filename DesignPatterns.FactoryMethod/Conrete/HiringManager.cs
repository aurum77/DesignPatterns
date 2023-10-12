using DesignPatterns.FactoryMethod.Abstract;

namespace DesignPatterns.FactoryMethod.Conrete;

public abstract class HiringManager
{
    protected abstract IInterviewer MakeInterviewer();
    public void TakeInterview()
    {
        var interviewer = this.MakeInterviewer();
        interviewer.AskQuestions();
    }
}
