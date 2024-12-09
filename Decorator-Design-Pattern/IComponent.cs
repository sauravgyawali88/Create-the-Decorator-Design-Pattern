// IComponent.cs
// Interface that defines the method for getting text of type T.

public interface IComponent<T>
{
    T GetText();
}
