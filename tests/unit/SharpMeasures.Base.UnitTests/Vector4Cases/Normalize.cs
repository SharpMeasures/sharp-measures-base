namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Normalize
{
    private static Vector4 Target(Vector4 vector) => vector.Normalize();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsArithmeticNormalization(Vector4 vector)
    {
        var expected = vector / vector.Magnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
