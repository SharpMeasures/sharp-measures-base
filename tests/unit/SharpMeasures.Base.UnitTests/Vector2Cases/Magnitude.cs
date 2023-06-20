namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Magnitude
{
    private static Scalar Target(Vector2 vector) => vector.Magnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsSquareRootOfSquaredMagnitude(Vector2 vector)
    {
        var expected = vector.SquaredMagnitude().SquareRoot();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
