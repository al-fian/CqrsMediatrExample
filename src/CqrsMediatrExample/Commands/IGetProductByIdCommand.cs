namespace CqrsMediatrExample.Commands
{
    public interface IGetProductByIdCommand
    {
        int Id { get; init; }

        void Deconstruct(out int Id);
        bool Equals(GetProductByIdCommand? other);
        bool Equals(object? obj);
        int GetHashCode();
        string ToString();
    }
}