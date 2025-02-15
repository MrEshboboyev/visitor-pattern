using Domain.Models;

namespace Domain.Interfaces;

public interface IProductVisitor
{
    void Visit(Electronics product);
    void Visit(Clothing product);
    void Visit(Groceries product);
}
