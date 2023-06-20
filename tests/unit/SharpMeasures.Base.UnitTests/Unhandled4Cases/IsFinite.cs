namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class IsFinite
{
    private static bool Target(Unhandled4 vector) => vector.IsFinite;

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsComponentsIsFinite(Unhandled4 vector)
    {
        var expected = vector.Components.IsFinite;
        var actual = Target(vector);

        Assert.Equal(expected, actual);
    }
}
