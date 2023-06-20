namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class AsIVector3Quantity_WithComponents_Scalars
{
    private static Unhandled3 Target(Scalar x, Scalar y, Scalar z)
    {
        return execute<Unhandled3>(x, y, z);

        static T execute<T>(Scalar x, Scalar y, Scalar z) where T : IVector3Quantity<T> => T.WithComponents(x, y, z);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudesOfProvidedUnhandled3_EqualsProvidedUnhandled3(Unhandled3 vector)
    {
        var actual = Target(vector.X.Magnitude, vector.Y.Magnitude, vector.Z.Magnitude);

        Assert.Equal(vector, actual);
    }
}
