namespace RefactoringGuru.DesignPatterns.Observer.Conceptual;

public interface IObserver
{
    // Receive update from subject
    void Update(ISubject subject);
}