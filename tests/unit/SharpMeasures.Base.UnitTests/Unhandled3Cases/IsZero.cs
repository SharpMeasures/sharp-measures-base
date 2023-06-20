namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class IsZero
{
    private static bool Target(Unhandled3 vector) => vector.IsZero;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsZero(Unhandled3 vector)
    {
        var expected = vector.Components.IsZero;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
