﻿using VisitorPatternInConsole.Visitors;

namespace VisitorPatternInConsole.Components;

// The Component interface declares an `accept` method that should take the base
// visitor interface as an argument.
public interface IComponent
{
    void Accept(IVisitor visitor);
}