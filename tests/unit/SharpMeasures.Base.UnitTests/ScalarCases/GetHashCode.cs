namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class GetHashCode
{
    private static int Target(Scalar scalar) => scalar.GetHashCode();

    [Fact]
    public void EqualInstances_Zero_SameHashCode() => EqualInstances_SameHashCode(Scalar.Zero, Scalar.Zero);

    [Fact]
    public void EqualInstances_NonZero_SameHashCode() => EqualInstances_SameHashCode(1.5, 1.5);

    [AssertionMethod]
    private static void EqualInstances_SameHashCode(Scalar firstScalar, Scalar secondScalar)
    {
        var firstHashCode = Target(firstScalar);
        var secondHashCode = Target(secondScalar);

        Assert.Equal(firstHashCode, secondHashCode);
    }
}
