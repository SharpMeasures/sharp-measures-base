namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class Operator_Cast_ToScalar
{
    private static Scalar Target(Unhandled unhandled) => (Scalar)unhandled;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsToScalar(Unhandled unhandled)
    {
        var expected = unhandled.ToScalar();
        var actual = Target(unhandled);

        Assert.Equal(expected, actual);
    }
}
