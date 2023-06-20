namespace SharpMeasures.UnhandledCases;

using Xunit;

public sealed class AsIScalarQuantity_WithMagnitude
{
    private static Unhandled Target(Scalar magnitude)
    {
        return execute<Unhandled>(magnitude);

        static T execute<T>(Scalar magnitude) where T : IScalarQuantity<T> => T.WithMagnitude(magnitude);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsConstructor(Scalar scalar)
    {
        Unhandled expected = new(scalar);
        var actual = Target(scalar);

        Assert.Equal(expected, actual);
    }
}
