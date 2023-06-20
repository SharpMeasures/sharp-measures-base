namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class IsInfinite
{
    private static bool Target(Unhandled2 vector) => vector.IsInfinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsInfinite(Unhandled2 vector)
    {
        var expected = vector.Components.IsInfinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
