namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class Operator_Cast_FromDouble
{
    private static Scalar Target(double value) => (Scalar)value;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ProvidedScalarToDouble_EqualsProvidedScalar(Scalar scalar)
    {
        var actual = Target(scalar.ToDouble());

        Assert.Equal(scalar, actual);
    }
}
