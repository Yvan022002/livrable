
namespace livrable.model;

using Depenses = SortedDictionary<Guid, Depense>;

public class DepensesProvider : IObservable<Depenses>
{
    private HashSet<IObserver<Depenses>> observers = [];
    public Depenses depenses { get; } = [];

    public IDisposable Subscribe(IObserver<Depenses> observer)
    {
        observers.Add(observer);
        return new Unsubscriber(observers, observer);
    }

    public void AddDepense(Depense depense)
    {
        depenses.Add(depense.Id, depense);

        foreach (var observer in observers)
        {
            observer.OnNext(depenses);
        }
    }

    internal void MockData()
    {
        List<Depense> deps =
        [
            // Janvier
            new("McDo", "Trio croquette", "nourriture", 17.35, new DateTime(2024, 1, 1)),
            new ("IGA", "Épicerie", "nourriture", 133.27, new DateTime(2024, 1, 1)),
            new ("Super C", "Épicerie", "nourriture", 141.15, new DateTime(2024, 1, 14)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 1, 31)),
            new ("En Fleurs", "Cactus", "loisirs", 23.28, new DateTime(2024, 1, 5)),
            
            // Février
            new ("IGA", "Épicerie", "nourriture", 97.60, new DateTime(2024, 2, 1)),
            new ("Musique & Cie.", "Nouveau stéréo", "loisirs", 543.78, new DateTime(2024, 2, 13)),
            new ("Super C", "Épicerie", "nourriture", 210.31, new DateTime(2024, 2, 14)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 2, 29)),
            new ("Le Nettoyeur", "Nettoyage vêtements", "services", 15.90, new DateTime(2024, 2, 18)),
        
            // Mars
            new ("IGA", "Épicerie", "nourriture", 147.41, new DateTime(2024, 3, 1)),
            new ("En Fleurs", "Cactus", "loisirs", 23.28, new DateTime(2024, 1, 5)),
            new ("McDo", "Trio McDo", "nourriture", 17.35, new DateTime(2024, 3, 7)),
            new ("IGA", "Épicerie", "nourriture", 111.38, new DateTime(2024, 3, 14)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 3, 31)),
        
            // Avril
            new ("Marché Central", "Fruits et légumes", "nourriture", 56.30, new DateTime(2024, 4, 5)),
            new ("Super C", "Épicerie", "nourriture", 128.25, new DateTime(2024, 4, 15)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 4, 30)),
            
            // Mai
            new ("Amazon", "Écouteurs sans fil", "technologie", 89.99, new DateTime(2024, 5, 10)),
            new ("IGA", "Épicerie", "nourriture", 134.50, new DateTime(2024, 5, 3)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 5, 31)),
        
            // Juin
            new ("La Ronde", "Billet d'entrée", "loisirs", 59.99, new DateTime(2024, 6, 10)),
            new ("Super C", "Épicerie", "nourriture", 152.75, new DateTime(2024, 6, 20)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 6, 30)),
        
            // Juillet
            new ("Cinemas Guzzo", "Billets cinéma", "loisirs", 28.50, new DateTime(2024, 7, 5)),
            new ("IGA", "Épicerie", "nourriture", 125.90, new DateTime(2024, 7, 2)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 7, 31)),
        
            // Août
            new ("Montréal en Lumière", "Tickets festival", "loisirs", 89.00, new DateTime(2024, 8, 5)),
            new ("Super C", "Épicerie", "nourriture", 102.75, new DateTime(2024, 8, 10)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 8, 31)),
        
            // Septembre
            new ("Apple Store", "iPhone", "loisirs", 999.99, new DateTime(2024, 9, 1)),
            new ("Super C", "Épicerie", "nourriture", 119.60, new DateTime(2024, 9, 14)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 9, 30)),
        
            // Octobre
            new ("Halloween en Folie", "Déguisement", "loisirs", 40.00, new DateTime(2024, 10, 10)),
            new ("Super C", "Épicerie", "nourriture", 115.90, new DateTime(2024, 10, 3)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 10, 31)),
        
            // Novembre
            new ("Walmart", "Télévision", "loisirs", 499.99, new DateTime(2024, 11, 28)),
            new ("Super C", "Épicerie", "nourriture", 135.75, new DateTime(2024, 11, 1)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 11, 30)),
        
            // Décembre
            new ("Amazon", "Cadeaux de Noël", "loisirs", 200.00, new DateTime(2024, 12, 1)),
            new ("IGA", "Épicerie", "nourriture", 145.40, new DateTime(2024, 12, 15)),
            new ("Immeubles DuCoin", "Loyer", "loyer", 623.00, new DateTime(2024, 12, 31)),
        ];

        foreach (var depense in deps)
        {
            depenses.Add(depense.Id, depense);
        }
    }

    internal sealed class Unsubscriber : IDisposable
    {
        private readonly ISet<IObserver<Depenses>> _observers;
        private readonly IObserver<Depenses> _observer;

        internal Unsubscriber(
            ISet<IObserver<Depenses>> observers,
            IObserver<Depenses> observer) => (_observers, _observer) = (observers, observer);

        public void Dispose() => _observers.Remove(_observer);
    }
}


