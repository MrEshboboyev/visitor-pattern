using Application.Visitors;
using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Services;

public class ProductService
{
    private readonly List<IProduct> _products = [];

    public ProductService()
    {
        _products.Add(new Electronics("Laptop", 1200.00m));
        _products.Add(new Clothing("Jacket", 100.00m));
        _products.Add(new Groceries("Apple", 5.00m));
    }

    public void ApplyDiscounts()
    {
        var discountVisitor = new DiscountVisitor();
        foreach (var product in _products)
        {
            product.Accept(discountVisitor);
        }
    }

    public void ApplyTaxes()
    {
        var taxVisitor = new TaxVisitor();
        foreach (var product in _products)
        {
            product.Accept(taxVisitor);
        }
    }
}
