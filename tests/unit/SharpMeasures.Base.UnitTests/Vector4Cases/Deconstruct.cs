namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Deconstruct
{
    private static (Scalar, Scalar, Scalar, Scalar) Target(Vector4 vector)
    {
        vector.Deconstruct(out var x, out var y, out var z, out var w);

        return (x, y, z, w);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponents(Vector4 vector)
    {
        var expected = (vector.X, vector.Y, vector.Z, vector.W);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
