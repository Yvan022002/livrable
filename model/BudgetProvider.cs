namespace livrable.model;

public class BudgetProvider : IObservable<double>
{
    private HashSet<IObserver<double>> observers = [];
    public double budget { get; } = 1000;

    public IDisposable Subscribe(IObserver<double> observer)
    {
        observers.Add(observer);
        return new Unsubscriber(observers, observer);
    }

    public void SetBudget()
    {
        foreach (var observer in observers)
        {
            observer.OnNext(budget);
        }
    }

    internal sealed class Unsubscriber : IDisposable
    {
        private readonly ISet<IObserver<double>> _observers;
        private readonly IObserver<double> _observer;

        internal Unsubscriber(
            ISet<IObserver<double>> observers,
            IObserver<double> observer) => (_observers, _observer) = (observers, observer);

        public void Dispose() => _observers.Remove(_observer);
    }
}
