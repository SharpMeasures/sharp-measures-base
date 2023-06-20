namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class PureSquaredMagnitude
{
    private static Scalar Target(Unhandled2 vector) => vector.PureSquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsSquaredMagnitude(Unhandled2 vector)
    {
        var expected = vector.Components.SquaredMagnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
