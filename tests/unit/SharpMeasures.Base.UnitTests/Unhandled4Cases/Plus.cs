namespace SharpMeasures.Unhandled4Cases;

using Xunit;

public sealed class Plus
{
    private static Unhandled4 Target(Unhandled4 vector) => vector.Plus();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedUnhandled4(Unhandled4 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
