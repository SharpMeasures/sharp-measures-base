namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class IsInfinite
{
    private static bool Target(Vector3 vector) => vector.IsInfinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsAnyComponentIsInfinite(Vector3 vector)
    {
        var expected = vector.X.IsInfinite || vector.Y.IsInfinite || vector.Z.IsInfinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
