namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class SquaredMagnitude
{
    private static Scalar Target(Vector3 vector) => vector.SquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsArithmeticSquaredMagnitude(Vector3 vector)
    {
        var expected = (vector.X * vector.X) + (vector.Y * vector.Y) + (vector.Z * vector.Z);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
