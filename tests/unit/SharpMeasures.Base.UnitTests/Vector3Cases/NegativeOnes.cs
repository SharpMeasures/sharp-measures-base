namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class NegativeOnes
{
    private static Vector3 Target() => Vector3.NegativeOnes;

    [Fact]
    public void AllComponentsAreNegativeOne()
    {
        Vector3 expected = (-1, -1, -1);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
