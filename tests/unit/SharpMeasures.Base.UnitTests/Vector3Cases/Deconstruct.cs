namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Deconstruct
{
    private static (Scalar, Scalar, Scalar) Target(Vector3 vector)
    {
        vector.Deconstruct(out var x, out var y, out var z);

        return (x, y, z);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponents(Vector3 vector)
    {
        var expected = (vector.X, vector.Y, vector.Z);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
