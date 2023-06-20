namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Constructor_Scalars
{
    private static Unhandled2 Target(Scalar x, Scalar y) => new(x, y);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudeOfComponentsOfProvidedUnhandled2_EqualsProvidedUnhandled2(Unhandled2 vector)
    {
        var actual = Target(vector.X.Magnitude, vector.Y.Magnitude);

        Assert.Equal(vector, actual);
    }
}
