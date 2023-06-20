namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class IsNaN
{
    private static bool Target(Vector4 vector) => vector.IsNaN;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsAnyComponentIsNaN(Vector4 vector)
    {
        var expected = vector.X.IsNaN || vector.Y.IsNaN || vector.Z.IsNaN || vector.W.IsNaN;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
