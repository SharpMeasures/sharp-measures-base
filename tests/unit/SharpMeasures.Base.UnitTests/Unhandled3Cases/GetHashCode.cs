namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(Unhandled3 vector) => vector.GetHashCode();

    [Fact]
    public void EqualInstances_Zero_SameHashCode() => EqualInstances_SameHashCode(Unhandled3.Zero, Unhandled3.Zero);

    [Fact]
    public void EqualInstances_NonZero_SameHashCode() => EqualInstances_SameHashCode(new(-1.5, 1.5, 4.5), new(-1.5, 1.5, 4.5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(Unhandled3 firstVector, Unhandled3 secondVector)
    {
        var firstHashCode = Target(firstVector);
        var secondHashCode = Target(secondVector);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
