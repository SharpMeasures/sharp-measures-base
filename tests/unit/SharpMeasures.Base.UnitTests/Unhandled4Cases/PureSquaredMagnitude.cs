namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class PureSquaredMagnitude
{
    private static Scalar Target(Unhandled4 vector) => vector.PureSquaredMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsSquaredMagnitude(Unhandled4 vector)
    {
        var expected = vector.Components.SquaredMagnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
