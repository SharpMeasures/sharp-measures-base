namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class IsZero
{
    private static bool Target(Vector3 vector) => vector.IsZero;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsEqualityWithZero(Vector3 vector)
    {
        var expected = vector == Vector3.Zero;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
