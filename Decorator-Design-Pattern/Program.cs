using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a ConcreteComponent instance with initial text
        IComponent<string> component = new ConcreteComponent("Hello, Decorator Pattern!");

        // Apply the PlainDecorator to add a prefix to the text
        IComponent<string> plainText = new PlainDecorator(component);
        Console.WriteLine(plainText.GetText());  // Print the text with "PlainDecorator: " prefix

        // Apply the ColorDecorator to change the text color to red
        IComponent<string> coloredText = new ColorDecorator(component);
        Console.WriteLine(coloredText.GetText());  // Print the text with red color

        // Apply the UpperCaseDecorator to convert the text to uppercase
        IComponent<string> upperCaseText = new UpperCaseDecorator(component);
        Console.WriteLine(upperCaseText.GetText());  // Print the text in uppercase

        // Combine multiple decorators: Color + Uppercase
        IComponent<string> coloredUpperCaseText = new UpperCaseDecorator(new ColorDecorator(component));
        Console.WriteLine(coloredUpperCaseText.GetText());  // Print the text in red and uppercase
    }
}

