namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(Unhandled unhandled) => unhandled.GetHashCode();

    [Fact]
    public void EqualInstances_Zero_SameHashCode() => EqualInstances_SameHashCode(Unhandled.Zero, Unhandled.Zero);

    [Fact]
    public void EqualInstances_NonZero_SameHashCode() => EqualInstances_SameHashCode(new(1.5), new(1.5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(Unhandled firstUnhandled, Unhandled secondUnhandled)
    {
        var firstHashCode = Target(firstUnhandled);
        var secondHashCode = Target(secondUnhandled);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
