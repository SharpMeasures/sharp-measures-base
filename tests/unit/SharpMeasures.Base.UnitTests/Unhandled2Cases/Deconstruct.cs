namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class Deconstruct
{
    private static (Unhandled, Unhandled) Target(Unhandled2 vector)
    {
        vector.Deconstruct(out var x, out var y);

        return (x, y);
    }

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponents(Unhandled2 vector)
    {
        var expected = (vector.X, vector.Y);
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
