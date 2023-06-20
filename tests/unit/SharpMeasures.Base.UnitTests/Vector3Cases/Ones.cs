namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Ones
{
    private static Vector3 Target() => Vector3.Ones;

    [Fact]
    public void AllComponentsAreOne()
    {
        Vector3 expected = (1, 1, 1);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
