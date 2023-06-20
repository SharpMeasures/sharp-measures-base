namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class PureSquaredMagnitude
{
    private static Scalar Target(Unhandled3 vector) => vector.PureSquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsSquaredMagnitude(Unhandled3 vector)
    {
        var expected = vector.Components.SquaredMagnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
