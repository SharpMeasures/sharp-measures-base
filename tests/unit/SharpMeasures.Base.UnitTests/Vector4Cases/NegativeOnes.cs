namespace SharpMeasures.Vector4Cases;

using Xunit;

public sealed class NegativeOnes
{
    private static Vector4 Target() => Vector4.NegativeOnes;

    [Fact]
    public void AllComponentsAreNegativeOne()
    {
        Vector4 expected = (-1, -1, -1, -1);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
