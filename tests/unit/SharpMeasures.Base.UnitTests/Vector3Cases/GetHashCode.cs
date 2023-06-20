namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(Vector3 vector) => vector.GetHashCode();

    [Fact]
    public void EqualInstances_Zero_SameHashCode() => EqualInstances_SameHashCode(Vector3.Zero, Vector3.Zero);

    [Fact]
    public void EqualInstances_NonZero_SameHashCode() => EqualInstances_SameHashCode((-1.5, 1.5, 4.5), (-1.5, 1.5, 4.5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(Vector3 firstVector, Vector3 secondVector)
    {
        var firstHashCode = Target(firstVector);
        var secondHashCode = Target(secondVector);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
