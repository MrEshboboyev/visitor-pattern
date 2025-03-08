using VisitorPatternInConsole.Components;
using VisitorPatternInConsole.Visitors;

namespace VisitorPatternInConsole;

public class Client
{
    // The Client code can run visitor operations over any set of elements
    // without figuring out their concrete classes. The accept operations
    // directs a call to the appropriate operation in the visitor object
    public static void ClientCode(List<IComponent> components, IVisitor visitor)
    {
        foreach (var component in components)
        {
            component.Accept(visitor);
        }
    }
}