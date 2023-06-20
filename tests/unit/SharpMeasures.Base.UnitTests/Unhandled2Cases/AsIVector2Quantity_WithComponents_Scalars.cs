namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class AsIVector2Quantity_WithComponents_Scalars
{
    private static Unhandled2 Target(Scalar x, Scalar y)
    {
        return execute<Unhandled2>(x, y);

        static T execute<T>(Scalar x, Scalar y) where T : IVector2Quantity<T> => T.WithComponents(x, y);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudesOfProvidedUnhandled2_EqualsProvidedUnhandled2(Unhandled2 vector)
    {
        var actual = Target(vector.X.Magnitude, vector.Y.Magnitude);

        Assert.Equal(vector, actual);
    }
}
