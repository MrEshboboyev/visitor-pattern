using Domain.Interfaces;
using Domain.Models;

namespace Application.Visitors;

public class TaxVisitor : IProductVisitor
{
    public void Visit(Electronics product)
    {
        decimal tax = product.Price * 0.15m; // 15% tax
        Console.WriteLine($"💰 Electronics Tax: {product.Name} - ${tax} tax");
    }

    public void Visit(Clothing product)
    {
        decimal tax = product.Price * 0.08m; // 8% tax
        Console.WriteLine($"🛍 Clothing Tax: {product.Name} - ${tax} tax");
    }

    public void Visit(Groceries product)
    {
        Console.WriteLine($"🥦 Groceries Tax: {product.Name} - No tax");
    }
}
