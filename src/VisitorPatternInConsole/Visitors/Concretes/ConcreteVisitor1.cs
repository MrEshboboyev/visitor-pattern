﻿using VisitorPatternInConsole.Components.Concretes;

namespace VisitorPatternInConsole.Visitors.Concretes;

// Concrete Visitors implement several reasons of the same algorithm, which can
// work with all concrete component classes.
//
// You can experience the biggest benefit of the Visitor pattern when using it
// with a complex object structure, such as a Composite tree. In this case, it
// might be helpful to store some intermediate state of the algorithm while
// executing visitor's methods over various objects of the structure.

public class ConcreteVisitor2 : IVisitor
{
    public void VisitConcreteComponentA(ConcreteComponentA element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteComponentA() + " + ConcreteVisitor2");
    }

    public void VisitConcreteComponentB(ConcreteComponentB element)
    {
        Console.WriteLine(element.SpecialMethodOfConcreteComponentB() + " + ConcreteVisitor2");
    }
}