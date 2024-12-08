namespace livrable.model;

public record struct Depense(
    string Entreprise,
    string Description,
    string Category,
    double Amount,
    DateTime Date
)
{
    public readonly Guid Id = Guid.NewGuid();

    public override readonly int GetHashCode()
    {
        return Id.GetHashCode();
    }
};