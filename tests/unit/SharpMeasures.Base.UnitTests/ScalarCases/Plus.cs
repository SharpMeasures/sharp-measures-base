namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Plus
{
    private static Scalar Target(Scalar scalar) => scalar.Plus();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedScalar(Scalar scalar)
    {
        var actual = Target(scalar);

        Assert.Equal(scalar, actual);
    }
}
