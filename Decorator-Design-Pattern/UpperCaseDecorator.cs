// This decorator converts the text returned by the base component to uppercase.
public class UpperCaseDecorator : Decorator<string>
{
    // Constructor to initialize with the component to be decorated
    public UpperCaseDecorator(IComponent<string> component) : base(component) { }

    // Converts the text to uppercase and returns it
    public override string GetText()
    {
        return base.GetText().ToUpper();  // Convert text to uppercase
    }
}

