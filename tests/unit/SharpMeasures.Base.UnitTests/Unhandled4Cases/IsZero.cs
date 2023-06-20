namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class IsZero
{
    private static bool Target(Unhandled4 vector) => vector.IsZero;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsZero(Unhandled4 vector)
    {
        var expected = vector.Components.IsZero;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
