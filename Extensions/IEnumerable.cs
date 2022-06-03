namespace DotNetHelpers.Extensions;
public static class IEnumerableExtensions {
    public static void Iterate<T>(this IEnumerable<T> items)
    {
        foreach (var item in items) { }
    }

    public static void Iterate<T>(this IEnumerable<T> items, Action<T> action)
    {
        foreach (var item in items)
            action(item);
    }

    public static void Iterate<T, R>(this IEnumerable<T> items, Func<T, R> action)
    {
        foreach (var item in items)
            action(item);
    }

    public static IEnumerable<T> SideAction<T>(
            this IEnumerable<T> items,
            Action<T> sideAction
        ) =>
        items.Select(item => {
                sideAction(item);
                return item;
            });

    public static IEnumerable<T> SideAction<T, R>(
            this IEnumerable<T> items,
            Func<T, R> sideAction
        ) =>
        items.Select(item => {
                sideAction(item);
                return item;
            });
}