// This decorator adds a prefix to the text returned by the base component.
public class PlainDecorator : Decorator<string>
{
    // Constructor to initialize with the component to be decorated
    public PlainDecorator(IComponent<string> component) : base(component) { }

    // Adds a prefix to the base text and returns it
    public override string GetText()
    {
        return $"PlainDecorator: {base.GetText()}";
    }
}
