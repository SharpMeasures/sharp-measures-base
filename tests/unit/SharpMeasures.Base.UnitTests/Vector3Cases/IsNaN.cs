namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class IsNaN
{
    private static bool Target(Vector3 vector) => vector.IsNaN;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsAnyComponentIsNaN(Vector3 vector)
    {
        var expected = vector.X.IsNaN || vector.Y.IsNaN || vector.Z.IsNaN;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
