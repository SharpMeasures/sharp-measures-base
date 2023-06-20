namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Constructor_Double
{
    private static Scalar Target(double value) => new(value);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ProvidedScalarToDouble_EqualsProvidedScalar(Scalar scalar)
    {
        var actual = Target(scalar.ToDouble());

        Assert.Equal(scalar, actual);
    }
}
