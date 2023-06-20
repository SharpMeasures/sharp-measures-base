namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Magnitude
{
    private static Scalar Target(Vector4 vector) => vector.Magnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSquareRootOfSquaredMagnitude(Vector4 vector)
    {
        var expected = vector.SquaredMagnitude().SquareRoot();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
