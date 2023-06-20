namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class AsIScalarQuantity_Magnitude
{
    private static Scalar Target(Scalar scalar)
    {
        return execute(scalar);

        static Scalar execute(IScalarQuantity quantity) => quantity.Magnitude;
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedScalar(Scalar scalar)
    {
        var actual = Target(scalar);

        Assert.Equal(scalar, actual);
    }
}
