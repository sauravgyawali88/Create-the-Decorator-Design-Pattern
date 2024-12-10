// This decorator colors the text returned by the base component in red using ANSI escape codes.
public class ColorDecorator : Decorator<string>
{
    // Constructor to initialize with the component to be decorated
    public ColorDecorator(IComponent<string> component) : base(component) { }

    // Applies red color to the text and returns it
    public override string GetText()
    {
        return $"\u001b[31m{base.GetText()}\u001b[0m";  // Apply red color to text
    }
}
