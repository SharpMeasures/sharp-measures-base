namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class PureMagnitude
{
    private static Scalar Target(Unhandled2 vector) => vector.PureMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsMagnitude(Unhandled2 vector)
    {
        var expected = vector.Components.Magnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
