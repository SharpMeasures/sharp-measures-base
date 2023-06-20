namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class IsNaN
{
    private static bool Target(Unhandled4 vector) => vector.IsNaN;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsNaN(Unhandled4 vector)
    {
        var expected = vector.Components.IsNaN;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
