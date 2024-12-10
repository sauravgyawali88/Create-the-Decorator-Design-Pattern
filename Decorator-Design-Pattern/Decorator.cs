// Decorator.cs
// Abstract class that implements IComponent and holds a reference to a component to decorate it.
public abstract class Decorator<T> : IComponent<T>
{
    // A field to hold the reference to the original component.
    protected IComponent<T> component;

    // Constructor to initialize the decorator with the component it decorates.
    public Decorator(IComponent<T> component)
    {
        this.component = component;  
    }

    // Override the GetText method to call the decorated component's GetText method.
    public virtual T GetText()
    {
        return component.GetText();
    }
}
