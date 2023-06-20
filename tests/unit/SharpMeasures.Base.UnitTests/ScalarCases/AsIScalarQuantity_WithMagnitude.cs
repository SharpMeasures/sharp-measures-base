namespace SharpMeasures.ScalarCases;

using Xunit;

public sealed class AsIScalarQuantity_WithMagnitude
{
    private static Scalar Target(Scalar magnitude)
    {
        return execute<Scalar>(magnitude);

        static T execute<T>(Scalar magnitude) where T : IScalarQuantity<T> => T.WithMagnitude(magnitude);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void ProvidedScalar_EqualsProvidedScalar(Scalar scalar)
    {
        var actual = Target(scalar);

        Assert.Equal(scalar, actual);
    }
}
