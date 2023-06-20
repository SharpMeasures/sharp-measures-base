namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class IsInfinite
{
    private static bool Target(Unhandled3 vector) => vector.IsInfinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsInfinite(Unhandled3 vector)
    {
        var expected = vector.Components.IsInfinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
