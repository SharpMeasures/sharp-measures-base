namespace SharpMeasures.Unhandled2Cases;

using Xunit;

public sealed class IsNaN
{
    private static bool Target(Unhandled2 vector) => vector.IsNaN;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsNaN(Unhandled2 vector)
    {
        var expected = vector.Components.IsNaN;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
