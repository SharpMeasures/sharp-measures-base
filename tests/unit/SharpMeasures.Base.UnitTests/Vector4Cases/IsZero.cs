namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class IsZero
{
    private static bool Target(Vector4 vector) => vector.IsZero;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsEqualityWithZero(Vector4 vector)
    {
        var expected = vector == Vector4.Zero;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
