namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class AsIVector4Quantity_WithComponents_Scalars
{
    private static Unhandled4 Target(Scalar x, Scalar y, Scalar z, Scalar w)
    {
        return execute<Unhandled4>(x, y, z, w);

        static T execute<T>(Scalar x, Scalar y, Scalar z, Scalar w) where T : IVector4Quantity<T> => T.WithComponents(x, y, z, w);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudesOfProvidedUnhandled4_EqualsProvidedUnhandled4(Unhandled4 vector)
    {
        var actual = Target(vector.X.Magnitude, vector.Y.Magnitude, vector.Z.Magnitude, vector.W.Magnitude);

        Assert.Equal(vector, actual);
    }
}
