namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(Unhandled4 vector) => vector.GetHashCode();

    [Fact]
    public void EqualInstances_Zero_SameHashCode() => EqualInstances_SameHashCode(Unhandled4.Zero, Unhandled4.Zero);

    [Fact]
    public void EqualInstances_NonZero_SameHashCode() => EqualInstances_SameHashCode(new(-4.5, -1.5, 1.5, 4.5), new(-4.5, -1.5, 1.5, 4.5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(Unhandled4 firstVector, Unhandled4 secondVector)
    {
        var firstHashCode = Target(firstVector);
        var secondHashCode = Target(secondVector);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
