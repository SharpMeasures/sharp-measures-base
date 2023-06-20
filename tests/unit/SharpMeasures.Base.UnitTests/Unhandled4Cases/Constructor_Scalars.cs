namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Constructor_Scalars
{
    private static Unhandled4 Target(Scalar x, Scalar y, Scalar z, Scalar w) => new(x, y, z, w);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudeOfComponentsOfProvidedUnhandled4_EqualsProvidedUnhandled4(Unhandled4 vector)
    {
        var actual = Target(vector.X.Magnitude, vector.Y.Magnitude, vector.Z.Magnitude, vector.W.Magnitude);

        Assert.Equal(vector, actual);
    }
}
