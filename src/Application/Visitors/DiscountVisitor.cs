using Domain.Interfaces;
using Domain.Models;

namespace Application.Visitors;

public class DiscountVisitor : IProductVisitor
{
    public void Visit(Electronics product)
    {
        decimal discount = product.Price * 0.10m; // 10% discount
        Console.WriteLine($"🔹 Electronics Discount: {product.Name} - ${discount} off");
    }

    public void Visit(Clothing product)
    {
        decimal discount = product.Price * 0.20m; // 20% discount
        Console.WriteLine($"👕 Clothing Discount: {product.Name} - ${discount} off");
    }

    public void Visit(Groceries product)
    {
        Console.WriteLine($"🥦 Groceries Discount: {product.Name} - No discount");
    }
}
