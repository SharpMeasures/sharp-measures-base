namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Constructor_Scalars
{
    private static Unhandled3 Target(Scalar x, Scalar y, Scalar z) => new(x, y, z);

    [Theory]
    [ClassData(typeof(Dataset))]
    public void MagnitudeOfComponentsOfProvidedUnhandled3_EqualsProvidedUnhandled3(Unhandled3 vector)
    {
        var actual = Target(vector.X.Magnitude, vector.Y.Magnitude, vector.Z.Magnitude);

        Assert.Equal(vector, actual);
    }
}
