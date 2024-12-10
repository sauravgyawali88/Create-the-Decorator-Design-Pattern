// This class implements IComponent<string> and provides a simple implementation for GetText().
public class ConcreteComponent : IComponent<string>
{
    private string _text;  // The text value to be returned

    // Constructor to initialize the component with a text value
    public ConcreteComponent(string text)
    {
        _text = text;
    }

    // Returns the text value
    public string GetText()
    {
        return _text;
    }
}