namespace livrable.model
{
    public class DepensesRepository : ISujet
    {
        private List<IObserver> observers = new List<IObserver>();
        private List<Depense> depenses = new List<Depense>();
        public DepensesRepository() { }

        public List<Depense> GetDepenses() { return depenses; }
        public void addDepense(Depense Depense)
        {
            depenses.Add(Depense);
            notifyObserver();
        }

        public void attachObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void detachObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(this);
            }
        }
    }
}
