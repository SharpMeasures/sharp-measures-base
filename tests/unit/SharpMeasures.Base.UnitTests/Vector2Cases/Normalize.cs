namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Normalize
{
    private static Vector2 Target(Vector2 vector) => vector.Normalize();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsArithmeticNormalization(Vector2 vector)
    {
        var expected = vector / vector.Magnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
