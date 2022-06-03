namespace DotNetHelpers.Extensions;
public static class Object {
    public static INamed<T> Named<T>(this T value, string name) =>
        new Named<T>(name, value);

    public static T Assert<T>(this T value, bool truthAssertion, Exception exception) {
        truthAssertion.AssertTrue(exception);

        return value;
    }

    public static T Assert<T>(this T value, Predicate<T> truthAssertionSelector, Func<T, Exception> exceptionSelector) {
        truthAssertionSelector(value).AssertTrue(() => exceptionSelector(value));

        return value;
    }

    public static void AssertTrue(this bool truthAssertion, Exception exception) {
        if(!truthAssertion)
            throw exception;
    }

    public static void AssertTrue(this bool truthAssertion, Func<Exception> exceptionSelector) {
        if(!truthAssertion)
            throw exceptionSelector();
    }
}