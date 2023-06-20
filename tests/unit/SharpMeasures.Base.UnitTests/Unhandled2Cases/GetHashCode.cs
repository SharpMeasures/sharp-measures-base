namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(Unhandled2 vector) => vector.GetHashCode();

    [Fact]
    public void EqualInstances_Zero_SameHashCode() => EqualInstances_SameHashCode(Unhandled2.Zero, Unhandled2.Zero);

    [Fact]
    public void EqualInstances_NonZero_SameHashCode() => EqualInstances_SameHashCode(new(-1.5, 1.5), new(-1.5, 1.5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(Unhandled2 firstVector, Unhandled2 secondVector)
    {
        var firstHashCode = Target(firstVector);
        var secondHashCode = Target(secondVector);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
