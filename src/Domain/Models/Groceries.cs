using Domain.Interfaces;

namespace Domain.Models;

public class Groceries(string name, decimal price) : IProduct
{
    public string Name { get; } = name;
    public decimal Price { get; } = price;

    public void Accept(IProductVisitor visitor)
    {
        visitor.Visit(this);
    }
}
