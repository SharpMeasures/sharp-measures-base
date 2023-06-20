namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class IsFinite
{
    private static bool Target(Unhandled3 vector) => vector.IsFinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsFinite(Unhandled3 vector)
    {
        var expected = vector.Components.IsFinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
