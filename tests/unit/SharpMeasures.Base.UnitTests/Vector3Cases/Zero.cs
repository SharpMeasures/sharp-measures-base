namespace SharpMeasures.Vector3Cases;

using Xunit;

public sealed class Zero
{
    private static Vector3 Target() => Vector3.Zero;

    [Fact]
    public void AllComponentsAreZero()
    {
        Vector3 expected = (0, 0, 0);
        var actual = Target();

        Assert.Equal(expected, actual);
    }
}
