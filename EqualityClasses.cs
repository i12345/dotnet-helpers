using System.Diagnostics.CodeAnalysis;

namespace DotNetHelpers;
public class EqualityClasses<T> : IEqualityComparer<T> {
    public List<List<T>> Classes { get; init; } = new();

    public bool Equals(T? x, T? y) =>
        (x == null && y == null) ||
        x != null && y != null &&
        Classes.Any(@class => @class.Contains(x) && @class.Contains(y));

    public int GetHashCode([DisallowNull] T obj) =>
        obj.GetHashCode();
}