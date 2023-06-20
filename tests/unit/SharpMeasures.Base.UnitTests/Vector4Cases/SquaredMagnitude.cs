namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class SquaredMagnitude
{
    private static Scalar Target(Vector4 vector) => vector.SquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsArithmeticSquaredMagnitude(Vector4 vector)
    {
        var expected = (vector.X * vector.X) + (vector.Y * vector.Y) + (vector.Z * vector.Z) + (vector.W * vector.W);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
