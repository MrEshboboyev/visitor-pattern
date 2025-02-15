namespace Domain.Interfaces;

public interface IProduct
{
    string Name { get; }
    decimal Price { get; }
    void Accept(IProductVisitor visitor);
}
