namespace DotNetHelpers;
public interface INamed<out T> {
    string Name { get; }
    T Value { get; }
}

public record Named<T>(string Name, T Value) : INamed<T> { }