namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class PureMagnitude
{
    private static Scalar Target(Unhandled3 vector) => vector.PureMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsMagnitude(Unhandled3 vector)
    {
        var expected = vector.Components.Magnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
