namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class IsFinite
{
    private static bool Target(Vector3 vector) => vector.IsFinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsAllComponentsAreFinite(Vector3 vector)
    {
        var expected = vector.X.IsFinite && vector.Y.IsFinite && vector.Z.IsFinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
