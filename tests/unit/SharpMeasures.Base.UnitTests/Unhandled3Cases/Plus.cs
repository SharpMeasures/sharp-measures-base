namespace SharpMeasures.Unhandled3Cases;

using Xunit;

public sealed class Plus
{
    private static Unhandled3 Target(Unhandled3 vector) => vector.Plus();

    [Theory]
    [ClassData(typeof(Dataset))]
    public void EqualsProvidedUnhandled3(Unhandled3 vector)
    {
        var actual = Target(vector);

        Assert.Equal(vector, actual);
    }
}
