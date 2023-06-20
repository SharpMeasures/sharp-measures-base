namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(Vector4 vector) => vector.GetHashCode();

    [Fact]
    public void EqualInstances_Zero_SameHashCode() => EqualInstances_SameHashCode(Vector4.Zero, Vector4.Zero);

    [Fact]
    public void EqualInstances_NonZero_SameHashCode() => EqualInstances_SameHashCode((-4.5, -1.5, 1.5, 4.5), (-4.5, -1.5, 1.5, 4.5));

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(Vector4 firstVector, Vector4 secondVector)
    {
        var firstHashCode = Target(firstVector);
        var secondHashCode = Target(secondVector);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
