namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class PureMagnitude
{
    private static Scalar Target(Unhandled4 vector) => vector.PureMagnitude();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsMagnitude(Unhandled4 vector)
    {
        var expected = vector.Components.Magnitude();
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
