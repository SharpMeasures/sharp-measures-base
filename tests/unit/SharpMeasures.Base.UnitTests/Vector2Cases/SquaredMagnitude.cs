namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class SquaredMagnitude
{
    private static Scalar Target(Vector2 vector) => vector.SquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsArithmeticSquaredMagnitude(Vector2 vector)
    {
        var expected = (vector.X * vector.X) + (vector.Y * vector.Y);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
