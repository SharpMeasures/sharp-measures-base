namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class IsNaN
{
    private static bool Target(Unhandled3 vector) => vector.IsNaN;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsNaN(Unhandled3 vector)
    {
        var expected = vector.Components.IsNaN;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
