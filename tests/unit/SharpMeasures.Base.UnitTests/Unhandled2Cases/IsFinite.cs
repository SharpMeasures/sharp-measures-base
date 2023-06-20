namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class IsFinite
{
    private static bool Target(Unhandled2 vector) => vector.IsFinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsFinite(Unhandled2 vector)
    {
        var expected = vector.Components.IsFinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
