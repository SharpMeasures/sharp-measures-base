namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class IsZero
{
    private static bool Target(Unhandled2 vector) => vector.IsZero;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsZero(Unhandled2 vector)
    {
        var expected = vector.Components.IsZero;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
