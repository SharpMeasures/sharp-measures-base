namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class Ones
{
    private static Vector4 Target() => Vector4.Ones;

    [Fact]
    public void AllComponentsAreOne()
    {
        Vector4 expected = (1, 1, 1, 1);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
