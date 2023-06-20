namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Normalize
{
    private static Vector3 Target(Vector3 vector) => vector.Normalize();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsArithmeticNormalization(Vector3 vector)
    {
        var expected = vector / vector.Magnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
