namespace SharpMeasures.Vector2Cases;

using Xunit;

public sealed class Deconstruct
{
    private static (Scalar, Scalar) Target(Vector2 vector)
    {
        vector.Deconstruct(out var x, out var y);

        return (x, y);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponents(Vector2 vector)
    {
        var expected = (vector.X, vector.Y);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
