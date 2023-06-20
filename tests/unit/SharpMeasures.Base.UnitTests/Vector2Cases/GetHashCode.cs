namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(Vector2 vector) => vector.GetHashCode();

    [Fact]
    public void EqualInstances_Zero_SameHashCode() => EqualInstances_SameHashCode(Vector2.Zero, Vector2.Zero);

    [Fact]
    public void EqualInstances_NonZero_SameHashCode() => EqualInstances_SameHashCode((-1.5, 1.5), (-1.5, 1.5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(Vector2 firstVector, Vector2 secondVector)
    {
        var firstHashCode = Target(firstVector);
        var secondHashCode = Target(secondVector);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
