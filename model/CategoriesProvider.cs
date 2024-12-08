
namespace livrable.model;

using Categories2 = SortedSet<string>;

public class CategoriesProvider : IObservable<Categories2>
{
    private HashSet<IObserver<Categories2>> observers = [];
    public Categories2 categories { get; } = [];

    public IDisposable Subscribe(IObserver<Categories2> observer)
    {
        observers.Add(observer);
        return new Unsubscriber(observers, observer);
    }

    public void AddCategory(string category)
    {
        if (!categories.Contains(category))
        {
            categories.Add(category);
            foreach (var observer in observers)
            {
                observer.OnNext(categories);
            }
        }
    }

    internal void MockData()
    {
        categories.Add("nourriture");
        categories.Add("loyer");
        categories.Add("loisirs");
        categories.Add("services");
    }

    internal sealed class Unsubscriber : IDisposable
    {
        private readonly ISet<IObserver<Categories2>> _observers;
        private readonly IObserver<Categories2> _observer;

        internal Unsubscriber(
            ISet<IObserver<Categories2>> observers,
            IObserver<Categories2> observer) => (_observers, _observer) = (observers, observer);

        public void Dispose() => _observers.Remove(_observer);
    }
}