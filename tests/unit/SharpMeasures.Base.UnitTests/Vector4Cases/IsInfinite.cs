namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class IsInfinite
{
    private static bool Target(Vector4 vector) => vector.IsInfinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsAnyComponentIsInfinite(Vector4 vector)
    {
        var expected = vector.X.IsInfinite || vector.Y.IsInfinite || vector.Z.IsInfinite || vector.W.IsInfinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
