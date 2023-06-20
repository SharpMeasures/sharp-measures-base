namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Magnitude
{
    private static Scalar Target(Vector3 vector) => vector.Magnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSquareRootOfSquaredMagnitude(Vector3 vector)
    {
        var expected = vector.SquaredMagnitude().SquareRoot();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
